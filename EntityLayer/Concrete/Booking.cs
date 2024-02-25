using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Booking
    {
        [Key]
        public int BookId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        [ForeignKey("RoomId")]
        public int RoomId { get; set; }
        public virtual Room? Room { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public List<Payment>? Payment { get; set; }

    }
}
