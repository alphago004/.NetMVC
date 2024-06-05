using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models; // Add this using directive


namespace WebAPIDemo.Controllers
{
    [ApiController]
    //[Route("api/[controller]")] // it is because our class name is ShirtControllers, so it will be the route to Shirt itself . Therefore we do not need to specify the route in all APIs. can use decorator '[Route ("[controller]")]' to specify the route to the controller itself.
    public class ShirtsControllers: ControllerBase {
        
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts() {
            return "reading all Shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtById (int id) {
            return $"Reading shirt with id {id}";
        }

        [HttpPost]
        [Route("/shirts")]
        public string CreateShirt ([FromForm] Shirt shirt) {
            return $"Creating a new shirt";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirt (int id)  {
            return $"Updating shirt with id {id}";
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirt (int id) {
            return $"Deleting shirt with id {id}";
        } 

    }
}
