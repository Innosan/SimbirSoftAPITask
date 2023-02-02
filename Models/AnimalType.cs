using System.ComponentModel.DataAnnotations;

namespace SimbirSoftAPITask1.Models
{
    public class AnimalType
    {
        public long Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
