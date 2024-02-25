using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [ForeignKey("BookingId")]
        public int? BookingId { get; set; }
        public virtual Booking? Booking {get;set;}
        public int? CreditCardNo { get; set; }
        public int? ExpireDate { get; set; }
    }
}
