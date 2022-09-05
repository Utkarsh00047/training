using pizza_company.Interfaces;
using pizza_company.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace pizza_company
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //IOnlineorder onlineorder = new Onlineorder();
            //onlineorder.create_offline_order();
            //connection string
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = pizza; User id=sa;Password=Bhavna@123");

            //login

            Console.WriteLine("Select Your Role 1 For Admin 2 For Franchise");
            int role = int.Parse(Console.ReadLine());
            string email,pass;
            int flag=0;

            if (role == 1)
            {
                Console.WriteLine("write admin email ");
                email = Console.ReadLine();

                Console.WriteLine("password: ");
                pass = Console.ReadLine();
                con.Open();
                SqlDataAdapter da_admin = new SqlDataAdapter("select * from admin_cred", con);
                DataSet ds_admin_login = new DataSet();
                da_admin.Fill(ds_admin_login, "admin_cred");
                if (email == ds_admin_login.Tables[0].Rows[0][3].ToString() && pass == ds_admin_login.Tables[0].Rows[0][2].ToString())
                {
                    flag = 1;
                    Console.WriteLine("Admin login successful");
                }
                else
                {
                    Console.WriteLine("wrong login");
                }
                con.Close();
            }

            if (role == 2)
            {
                Console.WriteLine("write franchise email ");
                email = Console.ReadLine();

                Console.WriteLine("password: ");
                pass = Console.ReadLine();
                con.Open();
                SqlDataAdapter da_fran = new SqlDataAdapter("select * from franchisee_cred", con);
                DataSet ds_fran = new DataSet();
                da_fran.Fill(ds_fran, "admin_cred");
                int x_fran = ds_fran.Tables[0].Rows.Count;

                for (int j = 0; j < x_fran; j++)
                {
                    if (email == ds_fran.Tables[0].Rows[j][3].ToString() && pass == ds_fran.Tables[0].Rows[j][2].ToString())
                    {
                        Console.WriteLine("franchisee login successful");
                        flag = 2;
                    }
                }
                
                con.Close();
            }

            SqlDataAdapter da_fran_list = new SqlDataAdapter("select * from franchisee_cred", con);
            DataSet ds_fran_list = new DataSet();
            da_fran_list.Fill(ds_fran_list, "franchisee_cred");
            int x_fran_list = ds_fran_list.Tables[0].Rows.Count;
            switch (flag)
            { 
                case 1:
                    Console.WriteLine("Press 1 to add franchise");
                    Console.WriteLine("Press 2 to view all franchise");
                    Console.WriteLine("Press 3 to fine franchise from code");
                    //Console.WriteLine("Press 4 to find sale according franchise code");
                    int choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            IFranchise franchise = new Franchise();
                            franchise.add_f();
                            break;
                        case 2:

                            for(int j = 0; j < x_fran_list; j++)
                            {
                                Console.WriteLine("Franchise name: " + ds_fran_list.Tables[0].Rows[j][1].ToString());
                                Console.WriteLine("Franchise email: " + ds_fran_list.Tables[0].Rows[j][3]);
                                Console.WriteLine("Franchise code: " + ds_fran_list.Tables[0].Rows[j][4]);
                                Console.WriteLine("Franchise contact Number: " + ds_fran_list.Tables[0].Rows[j][5].ToString());
                                Console.WriteLine("Franchise address: " + ds_fran_list.Tables[0].Rows[j][6].ToString());

                            }


                            break;

                        case 3:
                            Console.WriteLine("write franchise code");
                            string code = Console.ReadLine();

                            for (int j = 0; j < x_fran_list; j++)
                            {
                                if(code == ds_fran_list.Tables[0].Rows[j][4].ToString()){
                                    Console.WriteLine("Franchise name: " + ds_fran_list.Tables[0].Rows[j][1].ToString());
                                    Console.WriteLine("Franchise email: " + ds_fran_list.Tables[0].Rows[j][3]);
                                    Console.WriteLine("Franchise code: " + ds_fran_list.Tables[0].Rows[j][4]);
                                    Console.WriteLine("Franchise contact Number: " + ds_fran_list.Tables[0].Rows[j][5].ToString());
                                    Console.WriteLine("Franchise address: " + ds_fran_list.Tables[0].Rows[j][6].ToString());
                                }


                            }
                            break;
                        default:
                            Console.WriteLine("wrong choice");
                        break;
                           
                    }
                    break;
                case 2:
                    Console.WriteLine("press 1 for create online order");
                    Console.WriteLine("press 2 for create offline order");
                    int choice_fran = int.Parse(Console.ReadLine());
                    switch (choice_fran)
                    {
                        case 1:
                            IOnlineorder onlineorder = new Onlineorder();
                            onlineorder.create_online_order();
                            break;
                        case 2:
                            IOnlineorder onlineorder_offline = new Onlineorder();
                            onlineorder_offline.create_offline_order();
                            break;
                    }

                    break;
            }






        }
    }
}
