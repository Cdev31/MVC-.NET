using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("diagnoses")]
    public class DiagnosesModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public string disease { get; set; }

        public string severety { get; set; }

        public string notes { get; set; }

        [ForeignKey("medical_history_id")]
        public MedicalHistoryModel medicalHistory { get; set; }
        
    }
}