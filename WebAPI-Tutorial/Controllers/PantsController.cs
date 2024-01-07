using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController] //API Controller attribute
    [Route("api/[controller]")] // Routing template
                                // [controller] is a place holder for the controller (in this case pants)
                                // api/ changes all the url endpoints from https://localhost:7141/shirts/10 to https://localhost:7141/api/shirts/10
    public class PantsController: ControllerBase
    {
        [HttpGet] // Specifiyng the Verb    
        public string GetPants() // Action method
        {
            return "Reading all the pants";
        }

        [HttpGet("{id}")]
        public string GetPantsById(int id)
        {
            return $"Reading pants with ID: {id}";
        }

        [HttpPost]
        public string CreatePants()
        {
            return "Creating pants";
        }

        [HttpPut("{id}")]
        public string UpdatePants(int id)
        {
            return $"Updating pants with ID: {id}";
        }

        [HttpDelete("{id}")]
        public string DeletePants(int id)
        {
            return $"Deleting pants with ID: {id}";
        }
    }
}
