using System;
using System.Collections.Generic;
using System.Text;

namespace Fashion_app.Interfaces
{
    public interface IProduct
    {
        public int quantity { get; set; }
        public int P_price { get; set; }
        public string description { get; set; }
        void add_product();
    }
}
