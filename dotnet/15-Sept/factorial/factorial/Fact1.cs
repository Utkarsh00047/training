using System;
using System.Collections.Generic;
using System.Text;

namespace factorial
{
public class Fact1
    {
        //public float GetFactorialOf(int p)
        //{
        //    throw new NotImplementedException();
        //}


        //public float GetFactorialOf(int p)
        //{
        //    return 1;
        //}


        //public float GetFactorialOf(int p)
        //{
        //    if (p < 2)
        //        return 1;

        //    return p;
        //}

        public float GetFactorialOf(int p)
        {
            if (p < 2)
                return 1;

            return p * GetFactorialOf(p - 1);
        }
    }
}
