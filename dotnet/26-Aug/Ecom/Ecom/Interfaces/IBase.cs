using System;
using System.Collections.Generic;
using System.Text;
using Ecom.Models;

namespace Ecom.Interfaces
{
public interface IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
