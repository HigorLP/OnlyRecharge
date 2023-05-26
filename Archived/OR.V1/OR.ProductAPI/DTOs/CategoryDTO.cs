using OR.ProductAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OR.ProductAPI.DTOs;
public class CategoryDTO {
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "O nome da Categoria é obrigatório.")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }
    public ICollection<ProductModel>? Products { get; set; }
}
