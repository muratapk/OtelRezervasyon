using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hostel
    {
        [Key]
        public int HostelId { get; set; }
        public string HostelName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Suburb { get; set; } = string.Empty;
        public int? PostCode { get; set; }
        public string State { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public List<Employee>?Employees { get; set; }
        public List<Room>? Room { get; set; }
    }
}
