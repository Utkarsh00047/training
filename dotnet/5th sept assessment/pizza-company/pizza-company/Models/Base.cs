using pizza_company.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_company.Models
{
    public class Base : IBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
