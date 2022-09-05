using pizza_company.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace pizza_company.Models
{
    class Franchise : Base , IFranchise
    {
        public string f_pass { get; set; }
        public string f_email { get; set; }
        public string f_code { get; set; }
        public string f_number { get; set; }
        public string f_address { get; set; }

        void IFranchise.add_f()
        {
            Console.WriteLine("please enter following details to register franchise");
            Console.WriteLine("Enter Franchise Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Franchise pass");
            f_pass = Console.ReadLine();
            Console.WriteLine("Enter Franchise Email");
            f_email = Console.ReadLine();
            Console.WriteLine("Enter Franchise code");
            f_code = Console.ReadLine();
            Console.WriteLine("Enter Franchise Contact Number");
            f_number = Console.ReadLine();
            Console.WriteLine("Enter Franchise address");
            f_address = Console.ReadLine();

            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = pizza; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into franchisee_cred(franchisee_name,franchisee_pass,franchisee_email,franchisee_code,franchisee_cnumber,franchisee_address,franchisee_reg_date)" +
                "values ( '" + Name + "' , '"+ f_pass +"' , '"+ f_email +"' , '"+ f_code +"' , '"+ f_number +"', '"+f_address+ "',GETDATE())", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
