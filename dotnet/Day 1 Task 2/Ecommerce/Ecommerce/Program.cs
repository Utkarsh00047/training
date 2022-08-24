using System;
using Employee;
using Product;
using Customer;

namespace Ecommerce
{

    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";
            for (; answer.ToUpper() == "Y";)
            {
                Console.WriteLine("Welcome e-commerce website");
                Console.WriteLine("Press 1 to add the customer details");
                Console.WriteLine("Press 2 to add the employees details");
                Console.WriteLine("Press 3 to add the products details");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        customer c = new customer();
                        Console.WriteLine("Please Enter Customer Details:");
                        c.Cid = int.Parse(Console.ReadLine());
                        c.CName = Console.ReadLine();
                        c.CcontactNo = Console.ReadLine();
                        c.Caddress = Console.ReadLine();

                        Console.WriteLine("The values you entered are :");

                        c.Cshow();
                        break;

                    case 2:
                        employee e = new employee();
                        Console.WriteLine("Please Enter Employee Details:");
                        e.Eid = int.Parse(Console.ReadLine());
                        e.EName = Console.ReadLine();
                        e.EcontactNo = Console.ReadLine();
                        e.Eaddress = Console.ReadLine();

                        Console.WriteLine("The values you entered are :");

                        e.Eshow();
                        break;

                    case 3:
                        product p = new product();
                        Console.WriteLine("Please Enter Product Details:");

                        p.Pid = int.Parse(Console.ReadLine());
                        p.PName = Console.ReadLine();
                        p.Pprice = double.Parse(Console.ReadLine());

                        Console.WriteLine("The values you entered are :");

                        p.Pshow();

                        break;


                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }

                Console.WriteLine("Do you wish to continue? Y/N");
                answer = Console.ReadLine();
            }

        }
    }
}