using Fashion_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Fashion_app.Models
{
    class Category : Base, ICategory
    {
        public string category_code { get; set; }
        void ICategory.Category_create()
        {
            Console.Write("enter category name");
            string Name = Console.ReadLine();
            Console.Write("enter category code");
            string category_code = Console.ReadLine();
            SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = fashion; User id=sa;Password=Bhavna@123");
            SqlCommand cmd = new SqlCommand("insert into Category(cat_name,cat_code) values ( '" + Name + "','" + category_code + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //sql query to add cat
            Console.WriteLine("category added");
        }
    }
}
