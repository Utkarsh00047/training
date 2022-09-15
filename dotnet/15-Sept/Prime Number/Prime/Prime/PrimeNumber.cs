using System;
using System.Collections.Generic;
using System.Text;

namespace Prime
{
    public class PrimeNumber
    {
        //public float GetPrime(int p)
        //{
        //    throw new NotImplementedException();
        //}

        public float GetPrime(int p)
        {
            int n, i,  flag = 0;
            float m = 0.0F;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = (float)Math.Sqrt(n);
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("Number is Prime.");
            }
            return flag;
        }
    }
}
