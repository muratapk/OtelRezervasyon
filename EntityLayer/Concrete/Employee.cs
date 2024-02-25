using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int StaffId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string SubUrb { get; set; } = string.Empty;
        public int? PostCode { get; set; }
        public string PhoneNo { get; set; } = string.Empty;
       
        public string EmailAddress { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        [ForeignKey("HostelId")]
        public int HostelId { get; set; }
        public virtual Hostel? Hostel { get; set; }
    }
}
