using System.ComponentModel.DataAnnotations;
using WebApplication1.Controllers;

namespace WebApplication1.Models.Validations
{
    public class Shoes_EnsureCorrectSizingAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shoes = validationContext.ObjectInstance as Shoes; // Making sure i have a Shoes object

            if (shoes != null && !string.IsNullOrWhiteSpace(shoes.Gender))
            {
                if(shoes.Gender.Equals("men",StringComparison.OrdinalIgnoreCase) && shoes.Size < 39)
                {
                    return new ValidationResult("For men's shoes the size has to be greater than 39");
                }
                else if (shoes.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shoes.Size < 33)
                {
                    return new ValidationResult("For women's shoes the size has to be greater than 33");
                }
            }
            return ValidationResult.Success;
        }
    }
}
