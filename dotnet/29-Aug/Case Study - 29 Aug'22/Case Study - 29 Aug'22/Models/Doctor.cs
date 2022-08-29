using Case_Study___29_Aug_22.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Models
{
    class Doctor : Base, IDoctor
    {
        public string Department { get; set; }
        public string Email { get; set; }

        void IDoctor.create_Doctor()
        {
            Console.WriteLine("Enter the Doctor Details:");
            Console.WriteLine("Enter the Doctor ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Doctor Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Doctor Department:");
            Department = Console.ReadLine();
            Console.WriteLine("Enter the Doctor Email: ");
            Email = Console.ReadLine();
        }
        void IDoctor.ShowDoctor()
        {
            Console.WriteLine("The Doctor details are as follows: " + Id + " " + Name + " " + Department + " " + Email);
        }
    }
}
