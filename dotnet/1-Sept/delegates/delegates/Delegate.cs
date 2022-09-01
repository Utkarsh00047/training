using System;
using System.Collections.Generic;
using System.Text;

namespace genericdelegat
{
     public class Delegate
    {
        // Defining delegates
        public delegate double addDelegate(int x, float y, double z);
        public delegate void subtractDelegate(int x, float y, double z);
        public delegate bool checkLengthDelegate(string name);

        //Creation of functions

        public static double add(int a, float b, double c)
        {
            return a + b + c;
        }

        public static void subtract(int a, float b, double c)
        {
            Console.WriteLine(@"The subtraction of {0} {1} and {2} is {3}", a, b, c, (a - b - c));
        }

        public static bool checkLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

    }
}
