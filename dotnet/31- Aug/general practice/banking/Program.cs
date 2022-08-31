using System;
using System.Data;
using System.Data.SqlClient;

namespace banking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please do login first");
            Console.WriteLine("write email");
            string email = Console.ReadLine();
            Console.WriteLine("type password");
            string pass = Console.ReadLine();
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = banking; User id=sa;Password=Bhavna@123");
            int flag = 0;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from admin_details", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "admin_details");
                if (email == ds.Tables[0].Rows[0][2].ToString() && pass == ds.Tables[0].Rows[0][3].ToString())
                {
                flag = 1;
                }
                else
                {
                    Console.WriteLine("wrong login");
                }
            Customer cust = new Customer();

            for (; flag==1;)
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine("Press 1 for add customer");
                Console.WriteLine("Press 2 for view from email");
                Console.WriteLine("Press 3 for view all");
                Console.WriteLine("Press 4 for delete from email");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("type customer Name");
                        cust.cust_name = Console.ReadLine();
                        Console.WriteLine("type customer Email");
                        cust.cust_email = Console.ReadLine();
                        Console.WriteLine("type account no");
                        cust.cust_acc_no = Console.ReadLine();
                        Console.WriteLine("type submited money");
                        cust.balance = Console.ReadLine();

                        SqlCommand cmd = new SqlCommand("insert into cust_details(cust_name,cust_email,cust_acc_no,balance) values ( '" + cust.cust_name +"','"+cust.cust_email+"','"+cust.cust_acc_no+"','"+cust.balance+"')", con);


                        cmd.ExecuteNonQuery();


                        break;

                    case 2:
                        Console.WriteLine("type customer email to view");
                        string search_email = Console.ReadLine();

                        SqlDataAdapter da1 = new SqlDataAdapter("select * from cust_details", con);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "cust_details");

                        int x = ds1.Tables[0].Rows.Count;


                        for (int j = 0; j < x; j ++)
                        {
                            if (search_email == ds1.Tables[0].Rows[j][2].ToString())
                            {
                                Console.WriteLine("search done");
                                Console.WriteLine("Name: " + ds1.Tables[0].Rows[j][1].ToString());
                                Console.WriteLine("Email: " + ds1.Tables[0].Rows[j][2].ToString());
                                Console.WriteLine("account number: " + ds1.Tables[0].Rows[j][3].ToString());
                                Console.WriteLine("salary: " + ds1.Tables[0].Rows[j][4].ToString());

                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("List Of all customer");
                        SqlDataAdapter da2 = new SqlDataAdapter("select * from cust_details", con);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2, "cust_details");

                        int x1 = ds2.Tables[0].Rows.Count;


                        for (int k = 0; k < x1; k ++)
                        {
                            int l = k + 1;
                            Console.WriteLine("customer no:" + l);
                            Console.WriteLine("Name: " + ds2.Tables[0].Rows[k][1].ToString());
                            Console.WriteLine("Email: " + ds2.Tables[0].Rows[k][2].ToString());
                            Console.WriteLine("account number: " + ds2.Tables[0].Rows[k][3].ToString());
                            Console.WriteLine("salary: " + ds2.Tables[0].Rows[k][4].ToString());
                        }

                        break;

                    case 4:
                        Console.WriteLine("type customer email to view");
                        string delete_email = Console.ReadLine();
                        SqlCommand cmd2 = new SqlCommand("delete from cust_details where cust_email='"+ delete_email + "'", con);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Customer Deleted");
                        break;

                    default:
                        Console.WriteLine("You have entered wrong choice");
                        break;
                }

                Console.WriteLine("do you want to continue then press Y and if you want to logout press N");
                string cont = Console.ReadLine();
                if (cont == "N")
                {
                    flag = 0;
                }

            }
            


        }
    }
}
