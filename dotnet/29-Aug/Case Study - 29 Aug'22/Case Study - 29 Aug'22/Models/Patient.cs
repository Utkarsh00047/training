using Case_Study___29_Aug_22.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study___29_Aug_22.Models
{
    class Patient : Base, IPatient
    {
        public string p_Email { get; set; }

        void IPatient.register_patient()
        {
            Console.WriteLine("Enter the Patient Details:");
            Console.WriteLine("Enter the Patient ID:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Patient Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Patient Email:");
            p_Email= Console.ReadLine();

        }
        void IPatient.show_patient()
        {
            Console.WriteLine("The Patient details are as follows: " + Id + " " + Name + " " +p_Email);

        }
    }
}
