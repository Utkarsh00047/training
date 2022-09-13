using carapp.Enum;
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

                Console.WriteLine("\nHey Welcome Admin");
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
                        Console.WriteLine("Press 6 check Balancesheet");
                        Console.WriteLine("Press 7 for view Employee ");


                        int b = int.Parse(Console.ReadLine());
                        switch (b)
                        {
                            case (int)AppMenu.viewPart:
                                IPart part = new Part();
                                part.view_part();
                                break;
                            case (int)AppMenu.createPart:
                                IPart part_add = new Part();
                                //part_add.create_part();
                                Action<string> obj1 = new Action<string>(part_add.create_part);
                                obj1.Invoke("Part added");

                                break;
                            case (int)AppMenu.viewProduct:
                                //code for view product need to be created
                                IProduct product_view = new Product();
                                product_view.view_product();
                                break;
                            case (int)AppMenu.createProduct:
                                IProduct product = new Product();
                                product.create_product();
                                break;
                            case (int)AppMenu.workinghours:
                                IWorking working = new Working();
                                working.working_day_pay();
                                break;
                            case (int)AppMenu.balancesheet:
                                Blanacesheet bsheet = new Blanacesheet();
                                bsheet.bsheet();

                                break;
                            case (int)AppMenu.emp_view:
                                IEmp emp = new emp();
                                emp.view_emp();

                                break;
                            case (int)AppMenu.create_employee:
                                IEmp emp1 = new emp();
                                emp1.create_emp();

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
