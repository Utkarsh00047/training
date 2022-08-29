using Case_Study___29_Aug_22.Interfaces;
using Case_Study___29_Aug_22.Models;
using System;

namespace Case_Study___29_Aug_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";
            for (; answer.ToUpper() == "Y";)
            {
                Console.WriteLine("Hey Welcome to my Hospital Software:");
                Console.WriteLine("Please choose the desired input:");
                Console.WriteLine("Press 1 to create and view Doctor details");
                Console.WriteLine("Press 2 to create and view Patient details");
                Console.WriteLine("Press 3 to create and view Booked Bed details");

                int n = int.Parse(Console.ReadLine());

                IPatient Patient = new Patient();
                IDoctor Doctor = new Doctor();
                IBed Bed = new Bed();
                switch (n)
                {
                    case 1:
                        Doctor.create_Doctor();
                        Doctor.ShowDoctor();
                        break;

                    case 2:
                        Patient.register_patient();
                        Patient.show_patient();
                        break;

                    case 3:
                        Bed.Bookbed();
                        Bed.ShowBed();
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
