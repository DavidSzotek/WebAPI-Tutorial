using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController] //API Controller attribute
    [Route("api/[controller]")] // Routing template
    public class HatsController: ControllerBase
    {
        private List<Hat> hats = new List<Hat>()
        {
            new Hat{HatId=1, Brand = "Nike", Color = "Black", Gender = "Men", Price = 639, Size = 42},
            new Hat{HatId=2, Brand = "Adidas", Color = "Brown", Gender = "Women", Price = 799, Size = 42},
            new Hat{HatId=3, Brand = "Puma", Color = "White", Gender = "Women", Price = 1199, Size = 42},
            new Hat{HatId=4, Brand = "FILA", Color = "Blue", Gender = "Men", Price = 599, Size = 42}
        };

        [HttpGet] // Specifiyng the Verb    
        public string GetHats() // Action method
        {
            return "Reading all the hats";
        }

        [HttpGet("{id}")]
        public IActionResult GetHatById(int id) // IActionResult can return multiple data types (Including status code AND the Hat object
        {
            var hat = hats.FirstOrDefault(x => x.HatId == id);
            if(id <= 0)
            {
                BadRequest();
            }
            if (hat == null)
            {
                return NotFound(); // Convinience method
            }
            return Ok(hat);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSHat(int id)
        {
            return Ok($"Reading hat with ID: {id}");
        }
    }
}
