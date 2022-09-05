using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_company.Interfaces
{
    public interface IEmp
    {
        public string e_email { get; set; }
        public string e_code { get; set; }
        public string e_salary { get; set; }
        public string f_code { get; set; }

        void create_emp();
    }
}
