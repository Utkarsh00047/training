using Ecom.Interfaces;
using Ecom.Models;
using System;

namespace Ecom
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";
            for (; answer.ToUpper() == "Y";)
            {
                Console.WriteLine("Hey Welcome to my Ecommerce App:");
                Console.WriteLine("Please choose the desired input:");
                Console.WriteLine("Press 1 to create and view customer details");
                Console.WriteLine("Press 2 to create and view product details");
                Console.WriteLine("Press 3 to create and view order details");

                int n = int.Parse(Console.ReadLine());

                ICustomer customer = new Customer();
                IProduct product = new Product();
                IOrder order = new Order();
                switch (n)
                {
                    case 1:
                        customer.CreateCust();
                        customer.ShowCust();
                        break;

                    case 2:
                        product.CreateProduct();
                        product.showProduct();
                        break;

                    case 3:
                        order.createOrder();
                        order.showOrder();
                        break;

                    default:
                        Console.WriteLine("You have entered wron choice");
                        break;
                }
                Console.WriteLine("Do you wish to continue? Y/N");
                answer = Console.ReadLine();
            }
        }

    }
}
