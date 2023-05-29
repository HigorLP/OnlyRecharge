using OR.Domain.Models;

namespace OR.Domain.Interfaces; 
public interface IProductRepository {
    Task Add(ProductModel product);
    Task Update(ProductModel product);
    Task Delete(Guid id);
    Task<ProductModel> GetById(Guid id);
    Task<List<ProductModel>> GetAll();
}
