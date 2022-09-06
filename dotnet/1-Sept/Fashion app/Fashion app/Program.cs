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

            //login
            Console.WriteLine("please do login first");
            Console.WriteLine("write email");
            string email = Console.ReadLine();
            Console.WriteLine("type password");
            string pass = Console.ReadLine();
            SqlConnection con_login = new SqlConnection("server = BHAVNAWKS577; database = fashion; User id=sa;Password=Bhavna@123");
            int flag = 0;
            con_login.Open();
            SqlDataAdapter da_login = new SqlDataAdapter("select * from admin_details", con_login);
            DataSet ds_login = new DataSet();
            da_login.Fill(ds_login, "admin_details");
            if (email == ds_login.Tables[0].Rows[0][2].ToString() && pass == ds_login.Tables[0].Rows[0][3].ToString())
            {
                flag = 1;
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("wrong login");
            }
            con_login.Close();




            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = fashion; User id=sa;Password=Bhavna@123");
            string answer = "Y";

            if (flag == 1)
            {
                for (; answer.ToUpper() == "Y";)
                {
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
                    Console.WriteLine("Press 1 for adding category");
                    Console.WriteLine("Press 2 for adding Product");
                    Console.WriteLine("Press 3 for finding Product from category id");
                    Console.WriteLine("Press 4 for finding Product from product id");
                    Console.WriteLine("Press 5 for updating Product from product id");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ICategory cat = new Category();
                            Action<string> obj = new Action<string>(cat.Category_create);
                            obj.Invoke("category added");
                            break; 

                        case 2:
                            IProduct pro = new Product();
                            Action<string> obj_pro = new Action<string>(pro.add_product);
                            obj_pro.Invoke("product added");
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

                                    SqlDataAdapter da_find_cat = new SqlDataAdapter("select cat_name from Category where cat_id in(select cat_id from Product where pro_id=" + ds_pro.Tables[0].Rows[j][5] + ")", con);
                                    DataSet ds_find_cat = new DataSet();
                                    da_find_cat.Fill(ds_find_cat, "Product");
                                    int x_find_cat = ds_find_cat.Tables[0].Rows.Count;

                                    for (int i = 0; i < x_find_cat; i++)
                                    {
                                        Console.WriteLine("category name:" + ds_find_cat.Tables[0].Rows[i][0].ToString());
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
                                        Console.WriteLine("category name:" + ds_find_cat.Tables[0].Rows[i][0].ToString());
                                    }

                                }

                            }

                            break;
                        case 5:
                            Console.WriteLine("enter product id for update");
                            pro_id = int.Parse(Console.ReadLine());

                            Console.WriteLine("What You want to update?? press 1 for Product Name , 2 for Price, 3 for quantity");
                            int pro_change_choice = int.Parse(Console.ReadLine());

                            switch (pro_change_choice)
                            {
                                case 1:
                                    Console.WriteLine("enter product updated name");
                                    string update_name = Console.ReadLine();
                                    SqlCommand cmd = new SqlCommand("update Product set Pro_name='" + update_name + "' where pro_id=" + pro_id + "", con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    break;
                                case 2:
                                    Console.WriteLine("enter product updated price");
                                    int update_price = int.Parse(Console.ReadLine());

                                    SqlCommand cmd_price = new SqlCommand("update Product set pro_price='" + update_price + "' where pro_id=" + pro_id + "", con);
                                    con.Open();
                                    cmd_price.ExecuteNonQuery();
                                    con.Close();
                                    break;
                                case 3:
                                    Console.WriteLine("enter product updated quantity");
                                    int update_quantity = int.Parse(Console.ReadLine());

                                    SqlCommand cmd_quantity = new SqlCommand("update Product set pro_price='" + update_quantity + "' where pro_id=" + pro_id + "", con);
                                    con.Open();
                                    cmd_quantity.ExecuteNonQuery();
                                    con.Close();
                                    break;
                            }

                            break;
                    }
                    Console.WriteLine("Do you wish to continue with the menu? Y/N");
                    answer = Console.ReadLine();
                }
                Console.WriteLine("do you want to continue with the account then press Y and if you want to logout press N");
                string cont = Console.ReadLine();
                if (cont == "N")
                {
                    flag = 0;
                }
            }



        }
    }
}
