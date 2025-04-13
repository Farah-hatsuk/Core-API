using coreAPI.Server.DataService;
using coreAPI.Server.DTOs;
using coreAPI.Server.IDataService;
using coreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly coreAPI.Server.IDataService.IDataService _data;

        public CategoryController(coreAPI.Server.IDataService.IDataService data)
        {
            _data = data;
        }


        [HttpGet("getCategory")]
        public IActionResult getAllCategory()
        {
            var categoty = _data.getAllCategory();
            return Ok(categoty);
        }

        [HttpGet("getCategoryById/{id}")]
        public IActionResult getCategoryById(int id)
        {
            var category = _data.getCategoryById(id);
            if (category != null)
            {
                return Ok(category); //200
            }
            else
            {
                return NotFound(); // 404
            }
        }

        [HttpGet("getCategoryByName/{name:alpha}")]
        public IActionResult getCategoryByName(string name)
        {
            var category = _data.getCategoryByName(name);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getFirstCategory")]
        public IActionResult getFirstCategory()
        {
            var FirstCategory = _data.getFirstCategory();
            return Ok(FirstCategory);
        }

        [HttpDelete("deleteCategory")]
        public IActionResult deleteCategory([FromQuery] int id)
        {
            var category = _data.deleteCategory(id);
            if (category != false)
            {

                return Ok();
            }
            return NotFound();
        }

        [HttpPost("postCategory")]
        public IActionResult addCategory([FromBody] categoryDTO category)
        {
            if (category == null)
            {
                return BadRequest();
            }

            _data.addCategory(category);
            return Ok();
        }

        [HttpPut("updateCategory/{id}")]
        public IActionResult updateCategory(int id, [FromForm] Category category)
        {
            if (category == null)
                return BadRequest();

            var Update = _data.updateCategory(id, category);

            if (Update)
            {
                return Ok();

            }
            return BadRequest();
        }
    }
}
