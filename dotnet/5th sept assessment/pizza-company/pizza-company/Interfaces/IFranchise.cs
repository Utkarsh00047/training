using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_company.Interfaces
{
    public interface IFranchise
    {
        public string f_pass { get; set; }
        public string f_email { get; set; }
        public string f_code { get; set; }
        public string f_number { get; set; }
        public string f_address { get; set; }

        void add_f(string add_franchise);
    }
}
