using System;
using System.Data;
using System.Data.SqlClient;

namespace DB_Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";
            SqlConnection con =new SqlConnection("server = BHAVNAWKS577; database = Employee; User id=sa;Password=Bhavna@123");
            try {
                con.Open();
                Console.WriteLine("connection done");
                con.Close();
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            

            for (; answer.ToUpper() == "Y";)
            {
                Console.WriteLine("Hey Welcome to my DB App:");
                Console.WriteLine("Please choose the desired input:");
                Console.WriteLine("Press 1 to input details");
                Console.WriteLine("Press 2 to search details as per inserted id");
                Console.WriteLine("Press 3 to delete details as per inserted id");
                Console.WriteLine("Press 4 to update name as per inserted id");

                int n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 1:
                        Console.WriteLine("type employe ID");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("type employe Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("type employe salary");
                        string salary = Console.ReadLine();
                        Console.WriteLine("type employe Age");
                        int age = int.Parse(Console.ReadLine());

                        SqlCommand cmd = new SqlCommand("insert into emp_details values (" + id + ",'" + name + "','" + salary + "'," + age + ")",con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        break;

                    case 2:
                        Console.WriteLine("type employe ID to view");
                        int id1 = int.Parse(Console.ReadLine());

                        SqlDataAdapter da = new SqlDataAdapter("select * from emp_details", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "emp_details");

                        int x = ds.Tables[0].Rows.Count;


                        for (int i = 0; i < x; i++)
                        {
                            if (id1.ToString() == ds.Tables[0].Rows[i][0].ToString())
                            {
                                Console.WriteLine("Name: " + ds.Tables[0].Rows[i][1].ToString());
                                Console.WriteLine("salary: " + ds.Tables[0].Rows[i][2].ToString());
                                Console.WriteLine("age: " + ds.Tables[0].Rows[i][3].ToString());
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("type employe ID to delete");
                        int id2 = int.Parse(Console.ReadLine());

                        SqlCommand cmd2 = new SqlCommand("DELETE FROM emp_details WHERE id=" + id2 + "", con);

                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();

                        break;

                    case 4:
                        Console.WriteLine("type employe ID to update name");
                        int id3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("type new name");
                        string new_name = Console.ReadLine();

                        SqlCommand cmd3 = new SqlCommand("UPDATE emp_details set emp_name='" + new_name+"'  WHERE id=" + id3 + "", con);

                        con.Open();
                        cmd3.ExecuteNonQuery();
                        con.Close();

                        break;

                    default:
                        Console.WriteLine("You have entered wrong choice");
                        break;
                }
                Console.WriteLine("Do you wish to continue? Y/N");
                answer = Console.ReadLine();
            }
            }
    }
}
