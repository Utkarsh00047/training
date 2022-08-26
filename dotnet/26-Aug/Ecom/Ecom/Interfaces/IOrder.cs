using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Interfaces
{
    internal interface IOrder
    {
        string Date { get; set; }
        int noItems { get; set; }

        int totalAmount { get; set; }

        void createOrder();
        void showOrder();
    }
}
