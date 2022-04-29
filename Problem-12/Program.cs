using System;
using System.Collections.Generic;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 0,c = 0;
            for (int i = 1; c < 500 ; i++)
            {
                x += i;
                c = IsDivide(x);
            }


            Console.WriteLine(x);

        }
        
        static int IsDivide(int number)
        {
            int c = 0;
            for (int i = 1; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                {
                    c++;
                }
            }
            return 2*c;
        }
    }
}
