using OR.ProductAPI.Models;

namespace OR.ProductAPI.Repositories; 
public interface IProductRepository {
    Task<IEnumerable<ProductModel>> GetAll();
    Task<ProductModel> GetById(int id);
    Task<ProductModel> Create(ProductModel product);
    Task<ProductModel> Update(ProductModel product);
    Task<ProductModel> Delete(int id);
}
