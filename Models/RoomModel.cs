using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_practice.Models
{
    [Table("room")]
    public class RoomModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_name")]
        public string roomName { get; set; }

        [ForeignKey("area_id")]
        public AreaModel belongingArea { get; set; }
        
    }
}