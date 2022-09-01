using System;
using static genericdelegat.Delegate;
using static genericdelegat.GenericDelegate;

namespace genericdelegat
{
    class Program
    {
        static void Main(string[] args)
        {
            addDelegate obj = new addDelegate(add);
            subtractDelegate obj2 = new subtractDelegate(subtract);
            checkLengthDelegate obj3 = new checkLengthDelegate(checkLength);

            double result = obj.Invoke(12, 125.25f, 91.92);
            System.Console.WriteLine(result);

            obj2.Invoke(10, 5.5f, 1.5);

            bool status = obj3.Invoke("Utkarsh");
            Console.WriteLine(status);


            Func<int, float, double, double> obj4 = new Func<int, float, double, double>(addNumber);
            Action<int, float, double> obj5 = new Action<int, float, double>(subtractNumber);
            Predicate<string> obj6 = new Predicate<string>(checkLengthNumber);

            double res = obj4.Invoke(10, 120.25f, 63.04);
            Console.WriteLine(res);

            obj5.Invoke(8, 2.50f, 1.50);

            bool stats = obj6.Invoke("Utkash");
            Console.WriteLine(stats);
        }
    }
}
