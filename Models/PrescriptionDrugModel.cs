using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("prescription_drug")]
    public class PrescriptionDrugModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("drug_name")]
        public string drugName { get; set; }

        public string dose { get; set; }

        public string duration { get; set; }
        
        public string frecuency { get; set; }

        [ForeignKey("prescription_id")]
        public PrescriptionModel prescriptionId { get; set; }
        
        
    }
}