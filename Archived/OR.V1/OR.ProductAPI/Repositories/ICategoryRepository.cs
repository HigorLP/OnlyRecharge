using OR.ProductAPI.Models;

namespace OR.ProductAPI.Repositories;
public interface ICategoryRepository {
    Task<IEnumerable<CategoryModel>> GetAll();
    Task<IEnumerable<CategoryModel>> GetCategoriesProducts();
    Task<CategoryModel> GetById(int id);
    Task<CategoryModel> Create(CategoryModel category);
    Task<CategoryModel> Update(CategoryModel category);
    Task<CategoryModel> Delete(int id);
}
