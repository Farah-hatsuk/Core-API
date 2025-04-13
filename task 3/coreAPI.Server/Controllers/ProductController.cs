using coreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly coreAPI.Server.IDataService.IDataService _data;

        public ProductController(coreAPI.Server.IDataService.IDataService data)
        {
            _data = data;
        }

        [HttpGet("getProduct")]
        public IActionResult getAllProduct()
        {
            var Products = _data.getAllProduct();
            return Ok(Products);
        }

        [HttpGet("getProductById/{id}")]
        public IActionResult getProductById(int id)
        {
            var Product = _data.getProductById(id);
            if (Product != null)
            {
                return Ok(Product);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getProductByName/{name:alpha}")]
        public IActionResult getProductByName(string name)
        {
            var Product = _data.getProductByName(name);
            if (Product != null)
            {
                return Ok(Product);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getFirstProduct")]
        public IActionResult getFirstProduct()
        {
            var FirstProduct = _data.getFirstProduct();
            return Ok(FirstProduct);
        }

        [HttpDelete("deleteProduct")]
        public IActionResult deleteProduct([FromQuery] int id)
        {
            var product = _data.deleteProduct(id);
            if (product != false)
            {

                return Ok();
            }
            return NotFound();
        }
    }
}
