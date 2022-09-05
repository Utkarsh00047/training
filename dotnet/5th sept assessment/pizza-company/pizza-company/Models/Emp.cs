using pizza_company.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace pizza_company.Models
{
    class Emp : Base, IEmp
    {
        public string e_email { get; set; }
        public string e_code { get; set; }
        public string e_salary { get; set; }
        public string f_code { get; set; }

        void IEmp.create_emp()
        {
            Console.WriteLine("please enter following details to register Employee");
            Console.WriteLine("Enter Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Email");
            e_email = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            e_salary = Console.ReadLine();
            Console.WriteLine("Enter Franchise code");
            f_code = Console.ReadLine();
            Console.WriteLine("Enter employee code");
            e_code = Console.ReadLine();

            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = pizza; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into emp_detail(emp_name,emp_email,emp_code,emp_salary,franchisee_code,salary_distributed_date)" +
                "values ( '" + Name + "' , '" + e_email + "' , '" + e_code + "' , '" + e_salary + "' , '" + f_code + "', GETDATE())", con);
            con.Open();
            cmd.ExecuteNonQuery();  
            con.Close();
        }
    }
}