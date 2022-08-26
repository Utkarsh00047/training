using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Interfaces
{
    public interface IProduct
    {
        int Price { get; set; }
        int Quantity { get; set; }

        void CreateProduct();

        void showProduct();
    }
}
