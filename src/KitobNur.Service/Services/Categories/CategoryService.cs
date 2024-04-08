using AutoMapper;
using KitobNur.Data.IRepositories;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Categories;
using KitobNur.Service.Exseptions;
using KitobNur.Service.Extensions;
using KitobNur.Service.Interfaces.Categories;
using Microsoft.EntityFrameworkCore;


namespace KitobNur.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Category, int> _repository;

    public CategoryService(IMapper mapper,
                          IRepository<Category, int> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<CategoryResultDto> CreateAsync(CategoryDto dto)
    {
        var category = await _repository.SelectAll()
             .Where(r => r.Name.ToLower() == dto.Name.ToLower())
             .AsNoTracking()
             .FirstOrDefaultAsync();

        if (category is not null)
            throw new CustomException(409, "category is already exist!");

        var mapped = _mapper.Map<Category>(dto);

        var result = await _repository.InsertAsync(mapped);
        return _mapper.Map<CategoryResultDto>(result);
    }

    public async Task<CategoryResultDto> ModifyAsync(int id, CategoryDto dto)
    {
        var category = await _repository.SelectAll()
            .Where(r => r.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (category is null)
            throw new CustomException(404, "Category is not found!");

        var mapped = _mapper.Map(dto, category);
        mapped.UpdatedAt = DateTime.UtcNow;

        await _repository.UpdateAsync(mapped);

        return _mapper.Map<CategoryResultDto>(mapped);
    }
    public async Task<bool> RemoveAsync(int id)
    {
        var category = await _repository.SelectAll()
            .Where(r => r.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (category is null)
            throw new CustomException(404, "Category is not found!");

        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<CategoryResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var categories = await _repository.SelectAll()
            .AsNoTracking()
            .ToPagedList<Category, int>(@params); // Assuming ToPagedList is an extension method

        var categoryDtos = _mapper.Map<IEnumerable<CategoryResultDto>>(categories);
        return categoryDtos;
    }

    public async Task<CategoryResultDto> RetrieveByIdAsync(int id)
    {
        var region = await _repository.SelectAll()
            .Where(r => r.Id == id)
            .FirstOrDefaultAsync();

        if (region is null)
            throw new CustomException(404, "Region is not found!");

        return _mapper.Map<CategoryResultDto>(region);
    }
}
