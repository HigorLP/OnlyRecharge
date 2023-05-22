using Microsoft.AspNetCore.Mvc;
using OR.ProductAPI.DTOs;
using OR.ProductAPI.Services;

namespace OR.ProductAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase {

    private readonly IProductService _productService;

    public ProductsController(IProductService productService) {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> Get() {
        var productsDTO = await _productService.GetAllProducts();
        if (productsDTO is null)
            return NotFound("Produtos não encontrados.");

        return Ok(productsDTO);
    }

    [HttpGet("{id}", Name = "GetProduct")]
    public async Task<ActionResult<ProductDTO>> Get(int id) {
        var productDTO = await _productService.GetProductById(id);

        if (productDTO is null)
            return NotFound("Produto não encontrado.");

        return Ok(productDTO);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] ProductDTO productDTO) {
        if (productDTO is null)
            return BadRequest("Informações Incorretas");

        await _productService.AddProduct(productDTO);

        return new CreatedAtRouteResult("GetProdutct",
            new { id = productDTO.Id }, productDTO);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] ProductDTO productDTO) {
        if (id != productDTO.Id) {
            return BadRequest("Informações Incorretas");
        }

        if (productDTO is null)
            return BadRequest("Informações Incorretas");

        await _productService.UpdateProduct(productDTO);
        return Ok(productDTO);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ProductDTO>> Delete(int id) {
        var productDTO = await _productService.GetProductById(id);

        if (productDTO is null)
            return NotFound("Produto não encontrado.");

        await _productService.RemoveProduct(id);
        return Ok(productDTO);
    }
}
