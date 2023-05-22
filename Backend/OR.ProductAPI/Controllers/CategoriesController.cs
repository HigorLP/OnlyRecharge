using Microsoft.AspNetCore.Mvc;
using OR.ProductAPI.DTOs;
using OR.ProductAPI.Services;

namespace OR.ProductAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase {
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService) {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAll() {
        var categoriesDTO = await _categoryService.GetAllCategories();
        if (categoriesDTO is null)
            return NotFound("Categorias não encontradas.");

        return Ok(categoriesDTO);
    }

    [HttpGet("products")]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategoriasProducts() {
        var categoriesDTO = await _categoryService.GetCategoriesProducts();
        if (categoriesDTO == null) {
            return NotFound("Categorias não encontradas.");
        }
        return Ok(categoriesDTO);
    }

    [HttpGet("{id:int}", Name = "GetCategory")]
    public async Task<ActionResult<CategoryDTO>> Get(int id) {
        var categoryDTO = await _categoryService.GetCategoryById(id);
        if (categoryDTO == null) {
            return NotFound("Categoria não encontrada.");
        }
        return Ok(categoryDTO);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CategoryDTO categoryDTO) {
        if (categoryDTO == null) {
            return BadRequest("InvalidData");
        }
        await _categoryService.AddCategory(categoryDTO);
        return new CreatedAtRouteResult("GetCategory", new { id = categoryDTO.CategoryId },
            categoryDTO);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] CategoryDTO categoryDTO) {
        if (id != categoryDTO.CategoryId)
            return BadRequest();

        if (categoryDTO is null)
            return BadRequest();

        await _categoryService.UpdateCategory(categoryDTO);
        return Ok(categoryDTO);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<CategoryDTO>> Delete(int id) {
        var categoryDTO = await _categoryService.GetCategoryById(id);
        if (categoryDTO == null) {
            return NotFound("Categoria não encontrada.");
        }

        await _categoryService.RemoveCategory(id);

        return Ok(categoryDTO);
    }
}
