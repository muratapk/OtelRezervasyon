using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [ForeignKey("RoomTypeId")]
       
        public int? RoomTypeId { get; set; }
        public virtual RoomType? RoomType { get; set; }
        public string RoomImage { get; set; } = string.Empty;
        public string RoomDescription { get; set; } = string.Empty;
        [ForeignKey("HostelId")]
        public int? HostelId { get; set; }
        public virtual Hostel? Hostel { get; set; }
    }
}
