using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("medication")]
    public class MedicationModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public string drug { get; set; }

        public string dose { get; set; }

        public string duration { get; set; }
        
        public string observation { get; set; }

        [ForeignKey("medical_history_id")]
        public MedicalHistoryModel medicalHistory { get; set; }
        
    }
}