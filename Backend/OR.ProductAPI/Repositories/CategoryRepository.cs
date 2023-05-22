using Microsoft.EntityFrameworkCore;
using OR.ProductAPI.Data;
using OR.ProductAPI.Models;

namespace OR.ProductAPI.Repositories;
public class CategoryRepository : ICategoryRepository {

    private readonly DataContext _context;

    public CategoryRepository(DataContext context) {
        _context = context;
    }

    public async Task<IEnumerable<CategoryModel>> GetAll() {
        return await _context.Categories.ToListAsync();
    }

    public async Task<IEnumerable<CategoryModel>> GetCategoriesProducts() {
        return await _context.Categories.Include(c => c.Products).ToListAsync();
    }

    public async Task<CategoryModel> GetById(int id) {
        return await _context.Categories.Where(c => c.CategoryId == id).FirstOrDefaultAsync();
    }

    public async Task<CategoryModel> Create(CategoryModel category) {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<CategoryModel> Update(CategoryModel category) {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<CategoryModel> Delete(int id) {
        var category = await GetById(id);
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }
}
