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
            string relogin = "y";
            //login
            for (; relogin.ToUpper() == "Y";)
            {
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
                        string answer = "Y";
                        for (; answer.ToUpper() == "Y";)
                        {

                            da_fran_list.Fill(ds_fran_list, "franchisee_cred");
                            x_fran_list = ds_fran_list.Tables[0].Rows.Count;
                            Console.WriteLine("Press 1 to add franchise");
                            Console.WriteLine("Press 2 to view all franchise");
                            Console.WriteLine("Press 3 to fine franchise from code");
                            Console.WriteLine("Press 4 to find offline sale according franchise code");
                            Console.WriteLine("Press 5 to find online sale according franchise code");
                            Console.WriteLine("Press 6 to find online sale according to date");
                            Console.WriteLine("Press 7 to find offline sale according to date");

                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    IFranchise franchise = new Franchise();
                                    Action<string> obj = new Action<string>(franchise.add_f);
                                    obj.Invoke("franchise added");
                                    break;
                                case 2:

                                    for (int j = 0; j < x_fran_list; j++)
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
                                        if (code == ds_fran_list.Tables[0].Rows[j][4].ToString())
                                        {
                                            Console.WriteLine("Franchise name: " + ds_fran_list.Tables[0].Rows[j][1].ToString());
                                            Console.WriteLine("Franchise email: " + ds_fran_list.Tables[0].Rows[j][3]);
                                            Console.WriteLine("Franchise code: " + ds_fran_list.Tables[0].Rows[j][4]);
                                            Console.WriteLine("Franchise contact Number: " + ds_fran_list.Tables[0].Rows[j][5].ToString());
                                            Console.WriteLine("Franchise address: " + ds_fran_list.Tables[0].Rows[j][6].ToString());
                                        }


                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("write franchise code offline sale");
                                    string sale_f_code = Console.ReadLine();

                                    SqlDataAdapter da_offline_order = new SqlDataAdapter("SELECT SUM(offline_order_amount) FROM offline_sale WHERE offline_order_franchisee_code = '" + sale_f_code + "'", con);

                                    DataSet ds_offline_order = new DataSet();
                                    da_offline_order.Fill(ds_offline_order, "offline_sale");
                                    int x_offline_order = ds_offline_order.Tables[0].Rows.Count;
                                    Console.WriteLine("total sale =" + ds_offline_order.Tables[0].Rows[0][0]);
                                    break;
                                case 5:
                                    Console.WriteLine("write franchise code online sale");
                                    string sale_f_code_online = Console.ReadLine();

                                    SqlDataAdapter da_online_order = new SqlDataAdapter("SELECT SUM(online_order_amount) FROM online_sale WHERE online_order_franchisee_code = '" + sale_f_code_online + "'", con);

                                    DataSet ds_online_order = new DataSet();
                                    da_online_order.Fill(ds_online_order, "online_sale");
                                    int x_online_order = ds_online_order.Tables[0].Rows.Count;
                                    Console.WriteLine("total sale =" + ds_online_order.Tables[0].Rows[0][0]);
                                    break;
                                case 6:
                                    Console.WriteLine("write date of online sale");
                                    string sale_online_date = Console.ReadLine();

                                    SqlDataAdapter da_online_order_date = new SqlDataAdapter("SELECT SUM(online_order_amount) FROM online_sale WHERE online_order_date = '" + sale_online_date + "'", con);

                                    DataSet ds_online_order_date = new DataSet();
                                    da_online_order_date.Fill(ds_online_order_date, "online_sale");
                                    int x_online_order_date = ds_online_order_date.Tables[0].Rows.Count;
                                    Console.WriteLine("total sale =" + ds_online_order_date.Tables[0].Rows[0][0] + " of date " + sale_online_date);
                                    break;
                                case 7:
                                    Console.WriteLine("write date of offline sale");
                                    string sale_offline_date = Console.ReadLine();

                                    SqlDataAdapter da_offline_order_date = new SqlDataAdapter("SELECT SUM(offline_order_amount) FROM offline_sale WHERE offline_order_date = '" + sale_offline_date + "'", con);

                                    DataSet ds_offline_order_date = new DataSet();
                                    da_offline_order_date.Fill(ds_offline_order_date, "offline_sale");
                                    int x_offline_order_date = ds_offline_order_date.Tables[0].Rows.Count;
                                    Console.WriteLine("total sale =" + ds_offline_order_date.Tables[0].Rows[0][0] + " of date " + sale_offline_date);
                                    break;
                                default:
                                    Console.WriteLine("wrong choice");
                                    break;

                            }

                            Console.WriteLine("do you want to continue Y/N");
                            answer = Console.ReadLine();
                        }
                        break;
                    case 2:
                        answer = "Y";
                        for (; answer.ToUpper() == "Y";)
                        {


                            Console.WriteLine("press 1 for create online order");
                            Console.WriteLine("press 2 for create offline order");
                            Console.WriteLine("press 3 for new employee");
                            Console.WriteLine("press 4 for check Salary Distribution");
                            Console.WriteLine("press 5 for to Distribution of salary");

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
                                case 3:
                                    IEmp emp = new Emp();
                                    emp.create_emp();
                                    break;
                                case 4:

                                    Console.WriteLine("salary destribution: ");
                                    SqlDataAdapter da_salary = new SqlDataAdapter("select * from salary", con);
                                    DataSet ds_salary = new DataSet();
                                    da_salary.Fill(ds_salary, "salary");
                                    int x_salary = ds_salary.Tables[0].Rows.Count;
                                    for (int j = 0; j < x_salary; j++)
                                    {

                                        Console.WriteLine("Employee code " + ds_salary.Tables[0].Rows[j][1].ToString());
                                        Console.WriteLine("Salary: " + ds_salary.Tables[0].Rows[j][2].ToString());
                                        Console.WriteLine("Date: " + ds_salary.Tables[0].Rows[j][3].ToString());
                                    }


                                    break;
                                case 5:

                                    Console.WriteLine("enter employee code to destribute salary: ");
                                    string emp_c = Console.ReadLine();
                                    Console.WriteLine("enter salary");
                                    string emp_s = Console.ReadLine();
                                    SqlCommand cmd_s = new SqlCommand("insert into salary(emp_code,total_salary,sal_date) values ('" + emp_c + "','" + emp_s + "',GETDATE())", con);
                                    con.Open();
                                    cmd_s.ExecuteNonQuery();
                                    Console.WriteLine("salary destributed");
                                    con.Close();
                                    break;
                            }
                            Console.WriteLine("do you want to continue Y/N");
                            answer = Console.ReadLine();
                        }

                        break;
                }
                Console.WriteLine("press Y for relogin press N to end");
                relogin = Console.ReadLine();

            }




        }
    }
}
