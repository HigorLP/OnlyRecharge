using Microsoft.EntityFrameworkCore;
using OR.ProductAPI.Data;
using OR.ProductAPI.Models;

namespace OR.ProductAPI.Repositories;
public class ProductRepository : IProductRepository {
    private readonly DataContext _context;

    public ProductRepository(DataContext context) {
        _context = context;
    }

    public async Task<IEnumerable<ProductModel>> GetAll() {
        return await _context.Products.ToListAsync();
    }

    public async Task<ProductModel> GetById(int id) {
        return await _context.Products.Where(c => c.Id == id).FirstOrDefaultAsync();
    }

    public async Task<ProductModel> Create(ProductModel product) {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<ProductModel> Update(ProductModel product) {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<ProductModel> Delete(int id) {
        var product = await GetById(id);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
