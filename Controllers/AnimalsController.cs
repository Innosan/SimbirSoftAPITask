using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SimbirSoftAPITask1.Models;

namespace SimbirSoftAPITask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : Controller
    {


        static List<Animal> animals = new List<Animal>(new[]
        {
            new Animal() {
                Id = 1,
                AnimalTypes = AnimalTypesController.animalTypes.Select(at => at.Id).ToArray(),
                ChipingDateTime = new DateTime(2012, 12, 12),
                ChipperId = 1,
                Weight = 12,
                Height = 12,
                Length = 12,
                ChippingLocationId = 1,
                Gender = "Male",
                LifeStatus = "Alive",
                VisitedLocations = new[] {(long)1, (long)2 },
                DeathDateTime = new DateTime(2013, 12, 12),
            }
        });

        [HttpGet]
        public IEnumerable<Animal> GetAnimals() => animals;

        [HttpGet("(id)")]
        public IActionResult GetAnimal(int id)
        {
            var animal = animals.SingleOrDefault(animal => animal.Id == id);

            if (animal == default) { return NotFound(); }

            return Ok(animal);
        }
    }
}
