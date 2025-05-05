using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("user")]
    public class UserModel
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [ForeignKey("information")]
        public PersonInformationModel InformationId { get; set;}

        public string password { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [ForeignKey("role")]
        public RoleModel RoleId { get; set; }
        
    }
}