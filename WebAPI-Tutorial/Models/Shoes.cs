using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.Validations;

namespace WebApplication1.Models
{
    public class Shoes
    {
        public int ShoesId { get; set; }

        [Required]
        public string? Brand { get; set; } // string? = allows the property to be null

        [Required]
        public string? Color { get; set; }

        [Shoes_EnsureCorrectSizing]
        public int? Size { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(5)]
        public string? Gender { get; set; }

        public double? Price { get; set; }

        [Url]
        public string? UrlOfItem { get; set; }
    }
}
