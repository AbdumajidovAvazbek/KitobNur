using System;
using System.Windows;
using System.Windows.Controls;
using KitobNur.Data.DbContexts;
using KitobNur.Domain.Entities.Books;
using KitobNur.Service.Dtos.Books;
using KitobNur.Service.Interfaces.Books;
using Microsoft.EntityFrameworkCore;

namespace KitobNur.Desktop.Pages
{
    public partial class KitobQidirish : Page
    {
        private readonly IBookService _bookService;
        private readonly IServiceProvider _serviceProvider;

        public KitobQidirish(IBookService bookService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _bookService = bookService;
            _serviceProvider = serviceProvider;
        }



        private async void QidirishButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string author = Muallifi.Text;
                if (string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Please enter an author name!");
                    return;
                }

                using (var dbContext = new AppDbContext())
                {
                    var books = await dbContext.Books
                        .Where(p => EF.Functions.Like(p.Author.ToLower(), $"%{author.ToLower()}%"))
                        .ToListAsync();

                    if (books.Count > 0)
                    {
                        var bookDto = ConvertToBookDto(books[0]); // Assuming you want to pass only the first book
                        NavigationService.Navigate(new ViewBookPage(bookDto));
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private BookForResultDto ConvertToBookDto(Book book)
        {
            return new BookForResultDto
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Description= book.Description,
                Count = book.Count,
                Balance = book.Balance,
                CategoryId = book.CategoryId,
                ImagePath = book.ImagePath,
                Status = book.Status,
            };
        }


        private void OrtgaButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the previous page
            MainFrame.Navigate(new Kitob(_serviceProvider));
        }
    }
}
