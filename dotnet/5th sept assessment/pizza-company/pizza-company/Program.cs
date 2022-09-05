using pizza_company.Interfaces;
using pizza_company.Models;
using System;

namespace pizza_company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IFranchise franchise = new Franchise();
            //franchise.add_f();
            IOnlineorder onlineorder = new Onlineorder();
            onlineorder.create_offline_order();
        }
    }
}
