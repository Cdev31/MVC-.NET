using System.ComponentModel.DataAnnotations;

namespace mvc_practice.Schemas
{
    
    public class LoginDTOs: IValidatableObject
    {
      [Required( ErrorMessage = "email is required")]
      [EmailAddress(ErrorMessage ="emial is invalid")]
      public string email { get; set; }   

      [Required( ErrorMessage = "password is required")]
      [RegularExpression(@"^[A-Z][a-zA-Z0-9]*[\w\s\$].*")]
      public string password { get; set; }

      [Required( ErrorMessage = "confirmation password is required")]
      [RegularExpression(@"^[A-Z][a-zA-Z0-9]*[\w\s\$].*")]
      public string confirmationPassword { get; set; }

      public IEnumerable<ValidationResult> Validate( ValidationContext validationContext){
         
         if( password != confirmationPassword){
            
            yield return new ValidationResult(
                "The confirmation password does not match password",
                new[] { nameof(password), nameof(confirmationPassword)}
                );
         }
      }
    }
}