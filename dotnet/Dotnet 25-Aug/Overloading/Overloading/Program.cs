using System;

namespace Overloading
{
    public class overloading    
    {
        public static int add2(int one, int two)
        {
            Console.Write("sum of two numbers ");
            return one + two;
        }
        public static int add3(int one, int two, int three)
        {
            Console.WriteLine("sum of 3 Number ");
            return one + two + three;
        }
        public static string Numst_ring(string one, string two, string three, string four)
        {
            Console.WriteLine("concatenated string");
            return one + two + three + four;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(overloading.add2(2,3));
            Console.WriteLine(overloading.add3(1, 2, 3));
            Console.WriteLine(overloading.Numst_ring("1", "2", "3", "4"));
        }
    }
}
