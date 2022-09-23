using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        static void Main(string[] args)
        {
            //log.Info("This is a Calculator Program");
            //log.Fatal("Fatal message");
            //log.Debug("This is a Debug level");

            //Console.ReadLine();
            log.Info("User is using the calculator");
            try
            {
                Console.WriteLine("Enter 1st NUmber");
                int n1 = int.Parse(Console.ReadLine());
                log.Info("User has entered 1 st number " + n1);

                Console.WriteLine("Enter 2nd NUmber");
                int n2 = int.Parse(Console.ReadLine());
                log.Info("User has entered 2 st number " + n2);

                Console.WriteLine("Enter 1 for Addition");
                Console.WriteLine("Enter 2 for Subtraction");
                Console.WriteLine("Enter 3 for Multiplication");
                Console.WriteLine("Enter 4 for Division");

                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        int result = n1 + n2;
                        Console.WriteLine("Addition result= -" + result);
                        log.Info("Result -" + result);
                        log.Info("-----------------------------------------------------------------------------------------------");
                        break;


                    case 2:
                        int result1 = n1 - n2;
                        Console.WriteLine("Subtraction result= -" + result1);
                        log.Info("Result -" + result1);
                        log.Info("-----------------------------------------------------------------------------------------------");
                        break;


                    case 3:
                        int result2 = n1 * n2;
                        Console.WriteLine("Multiplication result= -" + result2);
                        log.Info("Result -" + result2);
                        log.Info("-----------------------------------------------------------------------------------------------");
                        break;


                    case 4:
                        int result3 = n1 / n2;
                        Console.WriteLine("Division result= " + result3);
                        log.Info("Result " + result3);
                        log.Info("-----------------------------------------------------------------------------------------------");
                        break;

                    default:
                        log.Error("Invalid input");
                        
                        break;
                }

            }
            catch(Exception ex)
            {
                log.Error("Error Occured", ex);
                throw;
            }
        }
    }
}
