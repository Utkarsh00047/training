using pizza_company.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace pizza_company.Models
{
    class Onlineorder : Base, IOnlineorder
    {
        public string cust_name { get; set; }
        public string f_code { get; set; }
        public int amount { get; set; }
        public string emp_code { get; set; }
        void IOnlineorder.create_online_order()
        {
            Console.WriteLine("please enter following details to create order");
            Console.WriteLine("Enter customer Name");
            cust_name = Console.ReadLine();
            Console.WriteLine("Enter franchise code");
            f_code = Console.ReadLine();
            Console.WriteLine("Enter Employee code");
            emp_code = Console.ReadLine();
            Console.WriteLine("Enter total amount");
            amount = int.Parse(Console.ReadLine());

            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = pizza; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into online_sale(online_order_customer_name,online_order_franchisee_code,online_order_amount,online_order_date,emp_code) values ( '" + cust_name + "' , '" + f_code + "' , '" + amount + "' , GETDATE() , '" + emp_code + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("order added");
            con.Close();

        }
        void IOnlineorder.create_offline_order()
        {
            Console.WriteLine("please enter following details to create order");
            Console.WriteLine("Enter customer Name");
            cust_name = Console.ReadLine();
            Console.WriteLine("Enter franchise code");
            f_code = Console.ReadLine();
            Console.WriteLine("Enter Employee code");
            emp_code = Console.ReadLine();
            Console.WriteLine("Enter total amount");
            amount = int.Parse(Console.ReadLine());

            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = pizza; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into offline_sale(offline_order_customer_name,offline_order_franchisee_code,offline_order_amount,offline_order_date,emp_code) values ( '" + cust_name + "' , '" + f_code + "' , '" + amount + "' , GETDATE() , '" + emp_code + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("order added");
            con.Close();

        }
    }
}
