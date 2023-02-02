using System.ComponentModel.DataAnnotations;

namespace SimbirSoftAPITask1.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        public long[] AnimalTypes { get; set; }

        [Required]
        public float Weight { get; set; }

        [Required]
        public float Length { get; set; }

        [Required]
        public float Height { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string LifeStatus { get; set; }

        [Required]
        public DateTime ChipingDateTime { get; set; }

        [Required]
        public int ChipperId { get; set; }

        [Required]
        public long ChippingLocationId { get; set; }

        [Required]
        public long[] VisitedLocations { get; set; }

        [Required]
        public DateTime? DeathDateTime { get; set; }
    }
}
