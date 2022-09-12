using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class Product : Base,IProduct
    {
        public string pro_code { get; set; }
        public int man_p_cost { get; set; }
        public int total_cost { get; set; }
        public int selling_price { get; set; }
        public int profit { get; set; }
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");

        void IProduct.create_product()
        {
            Console.WriteLine("Enter the Car Details: ");
            Console.WriteLine("Enter the Car Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Car selling Code :");
            pro_code = Console.ReadLine();
            Console.WriteLine("Enter the man power cost :");
            man_p_cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is your total Cost:");
            //total_cost = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("insert into emp(emp_name,emp_cost,emp_email,designation) values ( '" + Name + "' , '" + emp_cost + "' , '" + emp_email + "' , '" + designation + "' ", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
