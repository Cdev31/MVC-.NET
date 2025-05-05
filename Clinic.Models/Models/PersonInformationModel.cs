using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("person_information")]
    public class PersonInformationModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        public string firstname { get; set; }

        public string surname { get; set; }

        public string dui { get; set; }

        public string email { get; set; }

        public string gender { get; set; }

        [Column("phone_number")]
        public string phoneNUmber { get; set; }

        [Column("date_of_birth")]
        public DateOnly dateOfBirth { get; set; }
        
    }
}