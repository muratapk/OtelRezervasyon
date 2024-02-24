using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int? RoomPrice { get; set; }
        public List<Room>? Rooms { get; set; }
    }
}
