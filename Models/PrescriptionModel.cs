using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("prescription")]
    public class PrescriptionModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set;}

        [ForeignKey("appointment_id")]
        public AppoinmentModel appointmentId { get; set; }
        
        [Column("issue_date")]
        public DateOnly issueDate { get; set; }
    }
}