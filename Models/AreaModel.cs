using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("area")]
    public class AreaModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("area_name")]
        public string areaName { get; set; }

        [Column("floor_number")]
        public int floorNumber { get; set; }
        
    }
}