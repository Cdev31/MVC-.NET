using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_practice.Models
{
    [Table("role")]
    public class RoleModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("role_name")]
        public string roleName { get; set; }

        public string description { get; set; }
    }
}