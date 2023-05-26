using System.Collections;

namespace OR.ProductAPI.Models;
public class CategoryModel {
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public ICollection<ProductModel>? Products { get; set; }

}
