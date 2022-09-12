using System;
using System.Data.SqlClient;
using System.IO;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter email: ");
            string email = Console.ReadLine();
            Console.WriteLine("enter phone: ");
            string phone = Console.ReadLine();

            string combine = name+" " + email +" "+ phone + "\n";

            string fileName = @"C:\Users\Utkarsh.gupta\source\training-1\dotnet\9-sept\practice-1\test.txt";
            FileStream fs = File.Create(fileName);
            fs.Close();
            File.WriteAllText(fileName , combine);
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = file; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into info(u_name,u_email,u_phone) values ( '" + name + "','" + email + "','"+phone+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
