using carapp.Interface;
using carapp.Models;
using System;

namespace carapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPart part = new Part();
            var v= part.view_part();
            Console.WriteLine(v);


        }
    }
}
