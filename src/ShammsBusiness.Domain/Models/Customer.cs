using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShammsBusiness.Domain.Models
{
    public class Customer
    {
        public string FirsName { get; set; } = String.Empty;
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string VakilName { get; set; }
    }
}
