using OR.ProductAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace OR.ProductAPI.DTOs;
public class ProductDTO {
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do Produto é obrigatório.")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O Preço do Produto é obrigatório.")]
    public decimal Price { get; set; }
    public string? Description { get; set; }

    [Required(ErrorMessage = "É obrigatório adicionar a Quantidade do Produto ao Estoque.")]
    [Range(1, 9999)]
    public long Stock { get; set; }
    public string? Image { get; set; }
    public string? CategoryName { get; set; }

    [JsonIgnore]
    public CategoryModel? Category { get; set; }

    public int CategoryId { get; set; }
}
