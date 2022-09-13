using carapp.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace carapp.Models
{
    public class Working : Base, IWorking
    {
        public string working_date { get; set; }
        public int working_hours { get; set; }
        public int day_pay { get; set; }
        public int hourly_cost { get; set; }

        SqlConnection con = new SqlConnection("server = BHAVNAWKS577\\SQLEXPRESS; database = car; User id=sa;Password=Bhavna@123");

        void IWorking.working_day_pay()
        {
            Console.WriteLine("please enter details");
            Console.WriteLine("please enter employee id");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter date in the format of year-month-day ");
            working_date = Console.ReadLine();
            Console.WriteLine("Please enter total woking hours of that partivular date ");
            working_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hourly cost");
            hourly_cost = int.Parse(Console.ReadLine());

            if (working_hours > 8)
            {
                int x = working_hours - 8;
                day_pay = x * hourly_cost * 2 + hourly_cost * 8;
            }
            else
            {
                day_pay = working_hours * hourly_cost;
            }

            Console.WriteLine("total payment of date " + working_date + " is " + day_pay + " INR");

            SqlCommand cmd = new SqlCommand("insert into working_hours(emp_id,working_date,total_w_hours,day_payout) values ( " + Id + " , '" + working_date + "' , " + working_hours + " , " + day_pay + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
