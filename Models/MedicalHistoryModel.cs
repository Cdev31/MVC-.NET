using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("medical_history")]
    public class MedicalHistoryModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("responsible_doctor")]
        public DoctorModel responsibleDoctor { get; set; }

        [ForeignKey("patient_id")]
        public PatientModel patientId { get; set; }
    }
}