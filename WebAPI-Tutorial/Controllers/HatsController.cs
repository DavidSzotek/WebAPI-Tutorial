using Microsoft.AspNetCore.Mvc;
using WebAPI_Tutorial.Models.Repositories;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController] //API Controller attribute
    [Route("api/[controller]")] // Routing template
    public class HatsController: ControllerBase
    {
        [HttpGet] // Specifiyng the Verb    
        public string GetHats() // Action method
        {
            return "Reading all the hats";
        }

        [HttpGet("{id}")]
        public IActionResult GetHatById(int id) // IActionResult can return multiple data types (Including status code AND the Hat object
        {
            var hat = HatRepository.GetHatById(id);
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
