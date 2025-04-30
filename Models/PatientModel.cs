using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("patient")]
    public class PatientModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        public string firstname { get; set; }

        public string surname { get; set; }

        public string dui { get; set; }

        public string email { get; set; }

        public string gender { get; set; }

        [Column("blood_group")]
        public string bloodGroup { get; set; }

        [Column("date_of_birth")]
        public DateOnly dateOfBirth { get; set; }
    }
}