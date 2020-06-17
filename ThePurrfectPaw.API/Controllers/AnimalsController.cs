using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Services;

namespace ThePurrfectPaw.API.Controllers
{
    [Route("api/v1/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalRepository animalRespository;

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

        [HttpGet]
        public async Task<IActionResult> GetByShelter(int shelterId)
        {
            return NotFound();
        }
    }
}
