using System;
using System.Collections.Generic;
using System.Text;

namespace genericdelegat
{
    public class GenericDelegate
    {
        public static double addNumber(int a, float b, double c)
        {
            return a + b + c;
        }

        public static void subtractNumber(int a, float b, double c)
        {
            Console.WriteLine(@"The subtraction of {0} {1} and {2} is {3}", a, b, c, (a - b - c));
        }

        public static bool checkLengthNumber(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
