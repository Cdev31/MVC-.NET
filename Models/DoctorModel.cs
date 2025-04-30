using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("doctor")]
    public class DoctorModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        public PersonInformationModel information { get; set; }

        public string gender { get; set; }

        public string specialism { get; set; }

        [Column("medical_license")]
        public string medicalLicense { get; set; }

        public bool active { get; set; }

        [Column("hiring_date")]
        public DateOnly hiringDate { get; set; }

        [ForeignKey("work_area")]
        public AreaModel workArea { get; set; }
    }
}