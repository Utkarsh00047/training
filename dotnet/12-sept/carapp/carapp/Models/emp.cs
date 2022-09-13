using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class emp : Base , IEmp
    {
        public int emp_cost { get; set; }
        public string emp_email { get; set; }
        public string designation { get; set; }
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");

        void IEmp.create_emp()
        {
            Console.WriteLine("Enter the Employee Details: ");
            Console.WriteLine("Enter the Employee Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Employee email :");
            emp_email = Console.ReadLine();
            Console.WriteLine("Enter the Employee hourly cost :");
            emp_cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Designation :");
            designation = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into emp(emp_name,emp_cost,emp_email,designation) values ( '" + Name + "' , '" + emp_cost + "' , '" + emp_email + "' , '" + designation + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        void IEmp.view_emp()
        {
            con.Open();
            SqlDataAdapter da_emp = new SqlDataAdapter("select * from emp", con);
            DataSet ds_emp = new DataSet();
            da_emp.Fill(ds_emp, "part");
            int x = ds_emp.Tables[0].Rows.Count;
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine("Employee Name : " + ds_emp.Tables[0].Rows[j][1].ToString());
                Console.WriteLine("Employee cost : " + ds_emp.Tables[0].Rows[j][2].ToString());
                Console.WriteLine("Employee Email : " + ds_emp.Tables[0].Rows[j][3].ToString());
                Console.WriteLine("Employee Designation : " + ds_emp.Tables[0].Rows[j][3].ToString());

            }
            con.Close();
        }
    }
}
