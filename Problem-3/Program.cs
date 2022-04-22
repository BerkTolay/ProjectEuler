using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 20;
            List<long> list = new();
            //long temp = 2;



            for (long i = 2; i <= x; i++)
            {
                if (IsPrime(i) && x % i == 0)
                {

                    list.Add(i);
                    x /= i;
                    i = x % i == 0 ? i - 1 : i;

                    // if (x % i == 0)
                    // {
                    //     i--;
                    // }
                    // else
                    // {
                    //     temp = list[list.Count - 1];
                    //     break;
                    // }
                }

            }


            foreach (long item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsPrime(long number)
        {


            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return number == 2 ? true : false;
            }
            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
