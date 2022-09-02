using Fashion_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Fashion_app.Models
{
    class Product: Base, IProduct
    {
        public int quantity { get; set; }
        public int P_price { get; set; }

        public string description { get; set; }


        void IProduct.add_product(string pro_con)
        {
            Console.WriteLine("Enter Product Name ");
            Name = Console.ReadLine();
            Console.WriteLine("enter product quantity ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product Price ");
            P_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product description ");
            description = Console.ReadLine();

            Console.WriteLine("enter product category id ");
            int cat_id = int.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = fashion; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into Product(Pro_name,Pro_quantity,pro_price,pro_des,cat_id) values ( '" + Name + "'," + quantity + ","+P_price+",'"+description+"',"+cat_id+")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine(pro_con);
        }
    }
}
