using Ecom.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models
{
    public class Product : Base, IProduct
    {
        public int Price { get; set; }
        public int Quantity { get; set; }


        void IProduct.CreateProduct()
        {

            Console.WriteLine("Enter the Product Details:");
            Console.WriteLine("Enter the Product ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Product Price:");
            Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Product Quantity:");
            Quantity = int.Parse(Console.ReadLine());


        }

        void IProduct.showProduct()
        {

            Console.WriteLine("The product details are as follows: " + Id + " " + Name + " " + Price + " " + Quantity);

        }


    }
}
