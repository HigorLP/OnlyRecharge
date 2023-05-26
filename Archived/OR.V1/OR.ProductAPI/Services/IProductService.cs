using OR.ProductAPI.DTOs;

namespace OR.ProductAPI.Services; 
public interface IProductService {
    Task<IEnumerable<ProductDTO>> GetAllProducts();
    Task<ProductDTO> GetProductById(int id);
    Task AddProduct(ProductDTO productDTO);
    Task UpdateProduct(ProductDTO productDTO);
    Task RemoveProduct(int id);
}
