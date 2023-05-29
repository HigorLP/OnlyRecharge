namespace OR.Domain.Models;
public class ProductModel {
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public long Sku { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public Guid CategoryId { get; private set; }
    public CategoryModel Category { get; private set; }

    public ProductModel(Guid id, string name, string description, long sku, decimal price, int stock, Guid categoryId, CategoryModel category) {
        Id = id;
        Name = name;
        Description = description;
        Sku = sku;
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
        Category = category;
    }
}
