using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class Part : Base, IPart
    {
        public int part_cost { get; set; }
        public string part_code { get; set; }
        public int totalCost { get; set; }
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");

        void IPart.create_part(string part_added)
        {
            Console.WriteLine("Enter the Part Details: ");
            Console.WriteLine("Enter the Part Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Part Code: ");
            part_code = Console.ReadLine();
            Console.WriteLine("Enter the Part cost: ");
            part_cost = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into part(part_code,part_name,part_cost) values ( '" + part_code + "' , '" + Name + "' , " + part_cost + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine(part_added);
        }

        int IPart.view_part()
        {
            con.Open();
            int t_cost = 0;
            SqlDataAdapter da_part = new SqlDataAdapter("select * from part", con);
            DataSet ds_part = new DataSet();
            da_part.Fill(ds_part, "part");
            int x = ds_part.Tables[0].Rows.Count;
            for (int j = 0; j < x; j++)
            {
                Console.WriteLine("Part Code: " + ds_part.Tables[0].Rows[j][1].ToString());
                Console.WriteLine("Part Name: " + ds_part.Tables[0].Rows[j][2].ToString());
                Console.WriteLine("Part Cost: " + ds_part.Tables[0].Rows[j][3].ToString());
                t_cost = t_cost + int.Parse(ds_part.Tables[0].Rows[j][3].ToString());

            }

            con.Close();
            totalCost = t_cost;
            return t_cost;

        }
    }
}
