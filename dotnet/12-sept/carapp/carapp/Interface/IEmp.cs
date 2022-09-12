using System;
using System.Collections.Generic;
using System.Text;

namespace carapp.Interface
{
    public interface IEmp
    {
        public int emp_cost { get; set; }
        public string emp_email { get; set; }
        public string designation { get; set; }
        void create_emp();
        void view_emp();
    }
}
