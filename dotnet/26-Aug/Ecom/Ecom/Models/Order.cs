using System;
using Ecom.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models
{
    class Order : Base,IOrder
    {
        public string Date { get; set; }
        public int noItems { get; set; }

        public int totalAmount { get; set; }

        void IOrder.createOrder()
        {
            Console.WriteLine("Enter the Order Details:");
            Console.WriteLine("Enter the Order ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Order Date:");
            Date = Console.ReadLine();

            Console.WriteLine("Enter the Order No. of Items:");
            noItems = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Order total Amount:");
            totalAmount = int.Parse(Console.ReadLine());

        }
        void IOrder.showOrder()
        {
            Console.WriteLine("The Order details are as follows: " + Id + " " + Name + " " + Date + " " + noItems + " " + totalAmount);

        }
    }
}
