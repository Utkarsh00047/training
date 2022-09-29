using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeDetailsViewModel
    {
        public Employee employee { get; set; }
        public Address address { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
