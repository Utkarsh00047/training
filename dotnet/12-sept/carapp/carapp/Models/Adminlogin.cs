using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class Adminlogin : Base,IAdminlogin
    {
        bool IAdminlogin.ALogin(string a)
        {
            bool temp = false;

            try
            {
                Console.WriteLine("Enter the username for admin account:");
                Name = Console.ReadLine();

                Console.WriteLine("Enter the password for  admin account:");
                string Password = Console.ReadLine();

                SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");
                SqlDataAdapter da = new SqlDataAdapter("select * from admin", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "admin");

                int x = ds.Tables[0].Rows.Count;

                int count = 0;

                for (int i = 0; i < x; i++)
                {

                    if (Name.ToString() == ds.Tables[0].Rows[i][1].ToString() && Password.ToString() == ds.Tables[0].Rows[i][2].ToString())
                    {
                        count++;

                    }

                }
                if (count == 1)
                {

                    Console.WriteLine("Admin is Successfully Logged in: ");
                    temp = true;
                }
                else
                {
                    Console.WriteLine("Username and Password is Incorrect");
                    temp = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return temp;
        }
    }
}
