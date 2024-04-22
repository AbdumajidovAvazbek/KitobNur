using AutoMapper;
using KitobNur.Data.IRepositories;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Books;
using KitobNur.Service.Exseptions;
using KitobNur.Service.Extensions;
using KitobNur.Service.Interfaces.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KitobNur.Service.Services.Books
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly IRepository<Category, int> _categoryRepository;

        public BookService(IMapper mapper, IBookRepository bookRepository, IRepository<Category, int> categoryRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<BookForResultDto> CreateAsync(BookForCreationDto dto, IFormFile file)
        {
            // Check if file is not null and has content
            if (file == null || file.Length == 0)
                throw new CustomException(400, "File is required");

            var book = await _bookRepository.SelectAll()
                .Where(r => r.Name.ToLower() == dto.Name.ToLower())
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (book != null)
                throw new CustomException(409, "Book already exists!");

            var category = await _categoryRepository.SelectAll()
                .Where(c => c.Id == dto.CategoryId)
                .FirstOrDefaultAsync();

            if (category == null)
                throw new CustomException(404, "Category not found");

            // Process the file, e.g., save it to a location
            var filePath = Path.Combine("uploads", Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Map DTO to Book entity
            var mappedBook = _mapper.Map<Book>(dto);
            mappedBook.ImagePath = filePath; // Store the file path in the Book entity
            mappedBook.CategoryId = dto.CategoryId; // Assign the category ID to the Book entity

            var result = await _bookRepository.InsertAsync(mappedBook);
            return _mapper.Map<BookForResultDto>(result);
        }


        public async Task<BookForResultDto> ModifyAsync(long id, BookForUpdateDto dto)
        {
            var book = await _bookRepository.SelectAll()
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                throw new CustomException(404, "Book not found");

            _mapper.Map(dto, book);

            await _bookRepository.UpdateAsync(book);

            return _mapper.Map<BookForResultDto>(book);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var book = await _bookRepository.SelectAll()
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                throw new CustomException(404, "Book not found");

            await _bookRepository.DeleteAsync(id);

            return true;
        }

        public async Task<IEnumerable<BookForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var books = await _bookRepository.SelectAll()
                .OrderBy(b => b.Name)
                .ToPagedList<Book, long>(@params);

            return _mapper.Map<IEnumerable<BookForResultDto>>(books);
        }

        public async Task<BookForResultDto> RetrieveByAuthorAsync(string author)
        {
            if (author == null)
            {
                // Handle null author case
                return null; // Or throw an exception
            }
                var book = await _bookRepository.SelectAll()
                    .FirstOrDefaultAsync(b => b.Author.ToLower() == author.ToLower());

                if (book == null)
                    throw new CustomException(404, "Book not found");

                return _mapper.Map<BookForResultDto>(book);
        }

        public async Task<BookForResultDto> RetrieveByIdAsync(long id)
        {
            var book = await _bookRepository.SelectAll()
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                throw new CustomException(404, "Book not found");

            return _mapper.Map<BookForResultDto>(book);
        }

        public async Task<BookForResultDto> RetrieveByNameAsync(string name)
        {
            var book = await _bookRepository.SelectAll()
                .FirstOrDefaultAsync(b => b.Name.ToLower() == name.ToLower());

            if (book == null)
                throw new CustomException(404, "Book not found");

            return _mapper.Map<BookForResultDto>(book);
        }
    }
}
