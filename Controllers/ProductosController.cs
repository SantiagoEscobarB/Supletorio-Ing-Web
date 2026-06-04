using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Supletorio_Ing_Web.Interface;
using Supletorio_Ing_Web.Models;
using Supletorio_Ing_Web.Models.DTO;

namespace Supletorio_Ing_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {
        private readonly IProductService _IProductoService;

        public ProductosController(IProductService productService)
        {
            _IProductoService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductoDTO newProduct)
        {
            try
            {
                var createdProduct = await _IProductoService.create(newProduct);
                return Ok(createdProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll ()
        {
            try
            {
                var productList = await _IProductoService.getAll();
                return Ok(productList);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _IProductoService.getById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
