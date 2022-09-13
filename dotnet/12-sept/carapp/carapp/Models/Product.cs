using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class Product : Part, IProduct
    {
        public string pro_code { get; set; }
        public int man_p_cost { get; set; }
        public int total_cost { get; set; }
        public int selling_price { get; set; }
        public int profit { get; set; }
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577\\SQLEXPRESS; database = car; User id=sa;Password=Bhavna@123");

        void IProduct.create_product()
        {
            Console.WriteLine("Enter the Car Details: ");

            Console.WriteLine("Enter the Car selling Code Including car name which will be the complete code:");
            pro_code = Console.ReadLine();
            Console.WriteLine("Enter the man power cost :");
            man_p_cost = int.Parse(Console.ReadLine());
            
            total_cost = man_p_cost + totalCost;
            Console.WriteLine("Here is your total Cost: "+total_cost);

            Console.WriteLine("Please type selling price ");
            selling_price = int.Parse(Console.ReadLine());

            profit = selling_price - total_cost;
            Console.WriteLine("total profit is " + profit);

            SqlCommand cmd = new SqlCommand("insert into product(pro_code,man_p_cost,total_cost,selling_p,selling_date,profit) values ( '" + pro_code + "' , " + man_p_cost + " , " + total_cost + " , " + selling_price + ",GETDATE(),"+profit+" ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
