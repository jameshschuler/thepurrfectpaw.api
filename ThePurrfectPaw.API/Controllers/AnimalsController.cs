using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Services;

namespace ThePurrfectPaw.API.Controllers
{
    [Route("api/v1/animal")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalRepository animalRespository = null;

        public AnimalsController(IAnimalRepository repository)
        {
            animalRespository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var animals = await animalRespository.GetAll();

            return Ok(animals);
        }
    }
}
