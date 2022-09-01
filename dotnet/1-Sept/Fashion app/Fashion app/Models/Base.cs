using Fashion_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashion_app.Models
{
    public class Base : IBase
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
