using Microsoft.AspNetCore.Mvc;
using SimbirSoftAPITask1.Models;

namespace SimbirSoftAPITask1.Controllers
{
    [Route("api/Animals/[controller]")]
    [ApiController]
    public class AnimalTypesController : Controller
    {
        public static List<AnimalType> animalTypes = new List<AnimalType>(new[]
        {
            new AnimalType
            {
                Id = 1,
                Type = "Mammal"
            },
            new AnimalType
            {
                Id = 2,
                Type = "Beast"
            }
        });

        [HttpGet]
        public IEnumerable<AnimalType> GetAnimalTypes() => animalTypes;

        [HttpGet("(id)")]
        public IActionResult GetAnimalType(int id)
        {
            var animalType = animalTypes.SingleOrDefault(atype => atype.Id == id);

            if (animalType == default) return NotFound();

            return Ok(animalType);
        }
    }
}
