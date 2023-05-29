using OR.Domain.Interfaces;
using OR.Domain.Models;

namespace OR.Infrastructure.Repositories {
    public class ProductRepository : IProductRepository {
        private readonly ORContext _context;

        public ProductRepository(ORContext context) {
            _context = context;
        }

        public async Task Add(ProductModel product) {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ProductModel product) {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            var product = await _context.Products.FindAsync(id);
            if (product != null) {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ProductModel> GetById(Guid id) {
            return await _context.Products.FindAsync(id);
        }

        public async Task<List<ProductModel>> GetAll() {
            return await _context.Products.ToListAsync();
        }
    }
}
