using Case_Study___29_Aug_22.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Models
{
    class Bed: Patient, IBed
    {
        public int Price { get; set; }
        public string Bed_Code { get; set; }

        void IBed.Bookbed()
        {
            Console.WriteLine("Enter the Bed Details:");
            Console.WriteLine("Enter the Bed ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Bed Code:");
            Bed_Code = Console.ReadLine();
            Console.WriteLine("Enter the Bed Price:");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Patient Email:");
            p_Email = Console.ReadLine();
        }

        void IBed.ShowBed()
        {
            Console.WriteLine("The bed details are as follows: " + Id + " " + Bed_Code + " " + Price + " " + p_Email);

        }
    }
}
