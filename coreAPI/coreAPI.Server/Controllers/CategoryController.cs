using coreAPI.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _db;

        public CategoryController(MyDbContext db) 
        {
            _db = db;
        }

        [HttpGet("getCategory")]
        public IActionResult getAllCategory()
        {
            var categoty = _db.Categories.ToList();
            return Ok(categoty);
        }

        [HttpGet("getCategoryById")]
        public IActionResult getCategoryById(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
           if (category != null)
            {
                return Ok(category); //200
            }
            else
            {
                return NotFound(); // 404
            }
        }

        [HttpGet("getCategoryByName")]
        public IActionResult getCategoryByName(string name) 
        { 
            var category = _db.Categories.FirstOrDefault(x => x.Name == name);
            if (category != null)
            {
                return Ok(category);
            }
            else { 
            return NotFound();
            }
        }

        [HttpGet("getFirstCategory")]
        public IActionResult getFirstCategory()
        {
            var FirstCategory = _db.Categories.First();
            return Ok(FirstCategory);
        }
    }
}
