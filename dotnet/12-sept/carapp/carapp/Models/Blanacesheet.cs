using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace carapp.Models
{
    public class Blanacesheet
    {
            
        int totalCost { get; set; }
        int totalsale { get; set; }
        int totalprofit { get; set; }

        int total_Salary { get; set; }
        SqlConnection con = new SqlConnection("server = BHAVNAWKS577; database = car; User id=sa;Password=Bhavna@123");
        public void bsheet()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("exec sp_total", con);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet, "sp_total");

            SqlDataAdapter db = new SqlDataAdapter("exec d_total", con);
            DataSet ds = new DataSet();
            db.Fill(ds, "d_total");
            int y = ds.Tables[0].Rows.Count;
            int x = dataSet.Tables[0].Rows.Count;
            for (int i = 0; i < x; i++)
            {
                totalCost = int.Parse(dataSet.Tables[0].Rows[i][0].ToString());
                totalsale = int.Parse(dataSet.Tables[0].Rows[i][1].ToString());

                totalprofit = int.Parse(dataSet.Tables[0].Rows[i][2].ToString());
            }
            for (int j = 0; j < y; j++)
            {
                total_Salary = int.Parse(ds.Tables[0].Rows[j][0].ToString());
            }
            string path = @"C:\Users\Utkarsh.gupta\source\training-1\dotnet\12-sept\carapp\carapp\Sheet.txt";

            using (StreamWriter sw = File.AppendText(path))

            {

                sw.WriteLine("Total Cost: " + totalCost + " " + "Total Sale: " + totalsale + " " + "Total Profit: " + totalprofit + " " + "Total Salary: " + total_Salary);

                sw.WriteLine();



            }

            Console.WriteLine("Sheet Record Inserted Succesfully in file");

        }

    }
}

