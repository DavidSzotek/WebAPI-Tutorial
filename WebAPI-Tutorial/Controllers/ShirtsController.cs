using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController] //API Controller attribute
    public class ShirtsController: ControllerBase //Deriving from ControllerBase superclass
    {        
        [HttpGet] // Specifiyng the Verb  
        [Route("/shirts")] // Attribute routing (routing the URL to the action method
        public string GetShirts() // Action method
        {
            return "Reading all the shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading shirt with ID: {id}";
        }

        [HttpPost]
        [Route("/shirts")]
        public string CreateShirt()
        {
            return "Creating a shirt";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt with ID: {id}";
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt with ID: {id}";
        }
    }
}
