using System;
using System.Collections.Generic;
using System.Text;

namespace carapp.Interface
{
    public interface IProduct
    {
        public string pro_code { get; set; }
        public int man_p_cost { get; set; }
        public int total_cost { get; set; }
        public int selling_price { get; set; }
        public int profit { get; set; }
        void create_product();
        void view_product();

    }
}
