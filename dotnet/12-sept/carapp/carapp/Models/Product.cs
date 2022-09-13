using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
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
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");

        void IProduct.create_product()
        {
            Console.WriteLine("Enter the Car Details: ");

            Console.WriteLine("Enter the Car selling Code Including car name which will be the complete code:");
            pro_code = Console.ReadLine();
            Console.WriteLine("Enter the man power cost :");
            man_p_cost = int.Parse(Console.ReadLine());


            //part cost

            con.Open();
            int t_cost = 0;
            SqlDataAdapter da_part = new SqlDataAdapter("select * from part", con);
            DataSet ds_part = new DataSet();
            da_part.Fill(ds_part, "part");
            int x = ds_part.Tables[0].Rows.Count;
            for (int j = 0; j < x; j++)
            {

                t_cost = t_cost + int.Parse(ds_part.Tables[0].Rows[j][3].ToString());

            }

            con.Close();
            totalCost = t_cost;
            //part cost

            total_cost = man_p_cost + totalCost;
            Console.WriteLine("Here is your total Cost: "+total_cost);

            Console.WriteLine("Please type selling price ");
            selling_price = int.Parse(Console.ReadLine());

            profit = selling_price - total_cost;
            Console.WriteLine("total profit is " + profit);

            SqlCommand cmd = new SqlCommand("insert into product(pro_code,man_p_cost,total_cost,selling_p,selling_date,profit) values ( '" + pro_code + "' , " + man_p_cost + " , " + total_cost + " , " + selling_price + ",GETDATE(),"+profit+" )", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void IProduct.view_product()
        {
            con.Open();
            int t_cost = 0;
            SqlDataAdapter da_product = new SqlDataAdapter("select * from product", con);
            DataSet ds_product = new DataSet();
            da_product.Fill(ds_product, "product");
            int x = ds_product.Tables[0].Rows.Count;
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine("Product Code: " + ds_product.Tables[0].Rows[j][1].ToString());
                Console.WriteLine("Product Man Power Cost : " + ds_product.Tables[0].Rows[j][2].ToString());
                Console.WriteLine("Total  Cost: " + ds_product.Tables[0].Rows[j][3].ToString());
                Console.WriteLine("Selling Price : " + ds_product.Tables[0].Rows[j][4].ToString());
                Console.WriteLine("Selling Date : " + ds_product.Tables[0].Rows[j][5].ToString());
                Console.WriteLine("Profit :  " + ds_product.Tables[0].Rows[j][6].ToString());



            }

            con.Close();
        }
    }
}
