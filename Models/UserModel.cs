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

        public PersonInformationModel information { get; set;}

        public string password { get; set; }

        public RoleModel role { get; set; }
        
    }
}