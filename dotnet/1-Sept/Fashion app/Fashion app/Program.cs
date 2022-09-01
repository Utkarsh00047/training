using Fashion_app.Interfaces;
using Fashion_app.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Fashion_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = fashion; User id=sa;Password=Bhavna@123");

            Console.WriteLine("Press 1 for adding category");
            Console.WriteLine("Press 2 for adding Product");
            Console.WriteLine("Press 3 for finding Product from category id");
            Console.WriteLine("Press 3 for finding Product from product id");

            //category adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from Category", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");

            int x = ds.Tables[0].Rows.Count;

            //product adapter
            SqlDataAdapter da_pro = new SqlDataAdapter("select * from Product", con);
            DataSet ds_pro = new DataSet();
            da_pro.Fill(ds_pro, "Product");

            int x_pro = ds_pro.Tables[0].Rows.Count;

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ICategory cat = new Category();
                    cat.Category_create();
                break;

                case 2:
                    IProduct pro = new Product();
                    pro.add_product();
                break;

                case 3:
                    Console.WriteLine("write category id as per given categories");



                    for (int j = 0; j < x; j++)
                    {
                        
                            Console.WriteLine("search done");
                            Console.WriteLine("Category Id: " + ds.Tables[0].Rows[j][0].ToString());
                            Console.WriteLine("Name: " + ds.Tables[0].Rows[j][1].ToString());
                            Console.WriteLine("Special Code: " + ds.Tables[0].Rows[j][2].ToString());
                    }

                    //find product
                    Console.WriteLine("enter category id of which you want to show all products");
                    int cat_id = int.Parse(Console.ReadLine());

                    

                    for (int j = 0; j < x_pro; j++)
                    {
                        if (cat_id.ToString() == ds_pro.Tables[0].Rows[j][5].ToString())
                        {
                            Console.WriteLine("search done");
                            Console.WriteLine("Pro_name: " + ds_pro.Tables[0].Rows[j][1].ToString());
                            Console.WriteLine("Pro_quantity: " + ds_pro.Tables[0].Rows[j][2]);
                            Console.WriteLine("pro_price: " + ds_pro.Tables[0].Rows[j][3]);
                            Console.WriteLine("pro_des: " + ds_pro.Tables[0].Rows[j][4].ToString());
                            
                            SqlDataAdapter da_find_cat = new SqlDataAdapter("select cat_name from Category where cat_id in(select cat_id from Product where pro_id="+ ds_pro.Tables[0].Rows[j][5] + ")", con);
                            DataSet ds_find_cat = new DataSet();
                            da_find_cat.Fill(ds_find_cat, "Product");
                            int x_find_cat = ds_find_cat.Tables[0].Rows.Count;

                            for (int i = 0; i < x_find_cat; i++)
                            {
                                Console.WriteLine("category name:" + ds_find_cat.Tables[0].Rows[j][0].ToString());
                            }

                        }

                    }


                   break;

                case 4:
                    Console.WriteLine("enter product id");
                    int pro_id = int.Parse(Console.ReadLine());
                    for (int j = 0; j < x_pro; j++)
                    {
                        if (pro_id.ToString() == ds_pro.Tables[0].Rows[j][0].ToString())
                        {
                            Console.WriteLine("search done");
                            Console.WriteLine("Pro_name: " + ds_pro.Tables[0].Rows[j][1].ToString());
                            Console.WriteLine("Pro_quantity: " + ds_pro.Tables[0].Rows[j][2]);
                            Console.WriteLine("pro_price: " + ds_pro.Tables[0].Rows[j][3]);
                            Console.WriteLine("pro_des: " + ds_pro.Tables[0].Rows[j][4].ToString());

                            SqlDataAdapter da_find_cat = new SqlDataAdapter("select cat_name from Category where cat_id in(select cat_id from Product where pro_id=" + ds_pro.Tables[0].Rows[j][5] + ")", con);
                            DataSet ds_find_cat = new DataSet();
                            da_find_cat.Fill(ds_find_cat, "Product");
                            int x_find_cat = ds_find_cat.Tables[0].Rows.Count;

                            for (int i = 0; i < x_find_cat; i++)
                            {
                                Console.WriteLine("category name:" + ds_find_cat.Tables[0].Rows[j][0].ToString());
                            }

                        }

                    }

                    break;
            }

        }
    }
}
