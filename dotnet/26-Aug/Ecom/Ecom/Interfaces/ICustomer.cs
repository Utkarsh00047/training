using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Interfaces
{
    public interface ICustomer
    {
        public string Address { get; set; }
        public string Email { get; set; }

        void CreateCust();

        void ShowCust();
    }
}
