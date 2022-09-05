using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_company.Interfaces
{
    public interface IOnlineorder
    {
        public string cust_name { get; set; }
        public string f_code { get; set; }
        public int amount { get; set; }
        public string emp_code { get; set; }
        void create_online_order();
        void create_offline_order();

    }


}
