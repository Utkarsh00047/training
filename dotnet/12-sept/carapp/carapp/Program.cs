using carapp.Interface;
using carapp.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace carapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //IPart part = new Part();
            //var v= part.view_part();
            //Console.WriteLine(v);
            string answer = "Y";
            for (; answer.ToUpper() == "Y";)
            {

                Console.WriteLine("\nHey Welcome to MBenz, We're Glad that You are Here:");
                Console.WriteLine("Hey go for admin Login\n");
                IAdminlogin admin = new Adminlogin();
                Predicate<string> obj = new Predicate<string>(admin.ALogin);
                bool status = obj.Invoke("");

                if (status == true)
                {
                    string ay = "Y";
                    for (; ay.ToUpper() == "Y";)
                    {
                        Console.WriteLine("Hi, Admin Select the Desired Option: ");
                        Console.WriteLine("Press 1 for view parts ");
                        Console.WriteLine("Press 2 For add parts ");
                        Console.WriteLine("Press 3 for view product ");
                        Console.WriteLine("Press 4 To add product: ");
                        Console.WriteLine("Press 5 To add give day salary: ");
                        Console.WriteLine("Press 6 check monthly salary by employee id");


                        int b = int.Parse(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                IPart part = new Part();
                                part.view_part();
                                break;
                            case 2:
                                IPart part_add = new Part();
                                part_add.create_part();
                                break;
                            case 3:
                                    //code for view product need to be created
                                break;
                            case 4:
                                IProduct product = new Product();
                                product.create_product();
                                break;
                            case 5:
                                IWorking working = new Working();
                                working.working_day_pay();
                                break;


                        }


                        Console.WriteLine("Do you wish to continue with Admin Operations? Y/N");
                        ay = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You login credentials are incorrect:");
                }
                Console.WriteLine("Do you wish to continue with Another Login? Y/N");
                answer = Console.ReadLine();
            }

        }
    }
}
