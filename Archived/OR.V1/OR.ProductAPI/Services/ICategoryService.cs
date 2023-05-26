using OR.ProductAPI.DTOs;

namespace OR.ProductAPI.Services;
public interface ICategoryService {
    Task<IEnumerable<CategoryDTO>> GetAllCategories();
    Task<IEnumerable<CategoryDTO>> GetCategoriesProducts();
    Task<CategoryDTO> GetCategoryById(int id);
    Task AddCategory(CategoryDTO categoryDTO);
    Task UpdateCategory(CategoryDTO categoryDTO);
    Task RemoveCategory(int id);
}
