using System.ComponentModel.DataAnnotations;

namespace mvc_practice.Schemas
{
   public class OneOfAttribute: ValidationAttribute {
        private readonly string[] _allowed;

        public OneOfAttribute( params string[] allowed){
            _allowed = allowed;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if( value is string str && !_allowed.Contains(str.ToLower())){
                return new ValidationResult($"Gender must be Masculino or Femenino");
            }
            return ValidationResult.Success;
        }
    }
}