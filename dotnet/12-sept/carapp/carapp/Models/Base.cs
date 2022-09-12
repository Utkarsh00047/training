using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace carapp.Models
{
    public class Base : IBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
