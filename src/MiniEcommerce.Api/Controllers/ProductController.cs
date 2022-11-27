using Microsoft.AspNetCore.Mvc;
using MiniEcommerce.Domain.Entities;
using MiniEcommerce.Domain.Interfaces.Service;

namespace MiniEcommerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "getAll")]
        public async Task<IActionResult> GetAll()
        {

            //throw new BadHttpRequestException("teste erro");
            throw new Exception("teste erro");

            var teste = await _productService.GetAllAsync();

            return Ok(teste);
        }
        [HttpGet("/{id}")]
        public async Task<IActionResult> GetAll(string id)
        {

            var teste = await _productService.GetByIdAsync(Convert.ToInt32(id));

            return Ok(teste);
        }
        [HttpPost()]
        public async Task<IActionResult> GetAll([FromBody] Product product)
        {

            await _productService.InsertAsync(product);

            return Ok();
        }
        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeleteById(string id)
        {

            await _productService.DeleteByIdAsync(Convert.ToInt32(id));

            return Ok();
        }
        [HttpPost("/update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {

            await _productService.UpdateAsync(product);
            return Ok();
        }
    }
}
