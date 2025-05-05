using System.ComponentModel.DataAnnotations;

namespace mvc_practice.Clinic.DTOs
{
    public class CreateUserDTOs
    {
        [Required( ErrorMessage = " firstname is required ")]
        [MaxLength(10, ErrorMessage = "Name is too long")]
        public string firstname { get; set; }

        [Required( ErrorMessage = "surname is required ")]
        public string surname { get; set; }

        [Required( ErrorMessage = "dui is required")]
        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "Format invalid")]
        public string dui { get; set; }

        [Required(ErrorMessage = "email is required")]
        [EmailAddress( ErrorMessage = "Format invalid")]
        public string email { get; set; }

        [Required(ErrorMessage = "gender is required ")]
        [OneOf("Masculino", "Femenino")]
        public string gender { get; set; }

        [Required( ErrorMessage = "dateOfBirth is required")]
        [DataType( DataType.Date )]
        public DateOnly dateOfBirth { get; set; }

        [Required( ErrorMessage = "password is required")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9]*[^\w\$].*$")]
        public string password { get; set; }

        [Required( ErrorMessage = "password is required")]
        public int role { get; set; }

    }

    public class UpdateUserDTOs{

        [MaxLength(10, ErrorMessage = "Name is too long")]
        public string firstname { get; set; }

        [MaxLength(10, ErrorMessage = "Name is too long")]
        public string surname { get; set; }

        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "Format invalid")]
        public string dui { get; set; }

        [EmailAddress( ErrorMessage = "Format invalid")]
        public string? email { get; set; }

        [OneOf("Masculino", "Femenino")]
        public string gender { get; set; }

        [DataType( DataType.Date )]
        public DateOnly dateOfBirth { get; set; }

    }

    public class SetIdUserDTOs{

        [Required( ErrorMessage = "Id is required ")]
        public Guid Id { get; set; }
    }

    public class FindByEmailUserDTOs {

        [Required(ErrorMessage = "email required")]
        [EmailAddress( ErrorMessage = "Invalid format")]
        public string email { get; set; }
    }

    public class FindUserOuputDTOs{
        public Guid? Id { get; set; }

        public string allName { get; set; }

       public string dui { get; set; }

        public string email { get; set; }

        public string phoneNumber { get; set; }

        public string gender { get; set; }

        public DateOnly dateOfBirth { get; set; }

        public bool isActive { get; set; }

        public string role { get; set; }

    }
}