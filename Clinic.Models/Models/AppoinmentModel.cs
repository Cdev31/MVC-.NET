using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("appointment")]
    public class AppoinmentModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("appointment_date")]
        public DateOnly appointmentDate { get; set; }

        public string reasons { get; set; }

        [ForeignKey("doctor_id")]
        public DoctorModel doctorId { get; set; }

        [ForeignKey("patient_id")]
        public PatientModel patientId { get; set; }

        
        public string state { get; set; }
        
    }
}