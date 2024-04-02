using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Categories;

namespace KitobNur.Service.Interfaces.Categories;

public interface ICategoryService
{
    Task<bool> RemoveAsync(int id);
    Task<CategoryResultDto> RetrieveByIdAsync(int id);
    Task<CategoryResultDto> CreateAsync(CategoryDto dto);
    Task<CategoryResultDto> ModifyAsync(int id, CategoryDto dto);
    Task<IEnumerable<CategoryResultDto>> RetrieveAllAsync(PaginationParams @params);
}
