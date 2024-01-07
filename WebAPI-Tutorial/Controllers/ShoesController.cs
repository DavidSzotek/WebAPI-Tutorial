using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController] //API Controller attribute
    [Route("api/[controller]")] // Routing template
    public class ShoesController: ControllerBase
    {
        [HttpGet] // Specifiyng the Verb    
        public string GetShoes() // Action method
        {
            return "Reading all the shoes";
        }

        [HttpGet("{id}/{color}")]
        public string GetShoes([FromRoute]int id, [FromRoute]string color)
        {
            return $"Reading shoes with ID: {id} and COLOR: {color} from Route";
        }

        [HttpPut("{id}")]
        public string UpdateShoes([FromRoute] int id, [FromQuery] string color)
        {
            return $"Reading shoes with ID: {id} from Route and COLOR: {color.ToUpper()} from QueryString";
        }

        [HttpDelete("{id}")]
        public string DeleteShoes([FromRoute] int id, [FromHeader] string color)
        {
            return $"Reading shoes with ID: {id} from Route and COLOR: {color} from Header";
        }

        /*[HttpPost]
        public string CreateShoesFromBody([FromBody]Shoes shoes)
        {
            return $"Creating shoes";
        }*/

        [HttpPost]
        public string CreateShoesFromForm([FromForm]Shoes shoes)
        {
            return $"Creating shoes with ID: {shoes.ShoesId} of a BRAND: {shoes.Brand}, COLOR: {shoes.Color}";
        }
    }
}
