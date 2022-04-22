using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 2;
            while (true)
            {
                if (fib(i) >= 4000000)
                {
                    break;
                }
                if ((fib(i - 1) + fib(i)) % 2 == 0)
                {
                    sum += fib(i - 1) + fib(i);
                }

                i++;
            }
            Console.WriteLine(sum);
        }

        static int fib(int value)
        {
            if (value == 0)
            {
                return 0;
            }
            if (value == 1)
            {
                return 1;
            }
            return fib(value - 1) + fib(value - 2);
        }
    }
}
