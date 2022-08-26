using Ecom.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models
{
    class Customer : Base, ICustomer
    {
        public string Address { get; set; }
        public string Email { get; set; }
        void ICustomer.CreateCust()
        {
            Console.WriteLine("Enter the Customer Details:");
            Console.WriteLine("Enter the Customer ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the customer Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the Customer Email: ");
            Email = Console.ReadLine();
        }
        void ICustomer.ShowCust()
        {
            Console.WriteLine("The customer details are as follows: " + Id + " " + Name + " " + Address + " " + Email);
        }
    }
}
