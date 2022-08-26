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
                Console.WriteLine("Press 1 to create customer details");
                Console.WriteLine("Press 2 to display customer details");
                Console.WriteLine("Press 3 to create product details");
                Console.WriteLine("Press 4 to display product details");
                Console.WriteLine("Press 5 to create order details");
                Console.WriteLine("Press 6 to display order details");

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

                    case 3:
                        product.CreateProduct();
                        break;
                    case 4:
                        product.showProduct();
                        break;

                    case 5:
                        order.createOrder();
                        break;

                    case 6:
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
