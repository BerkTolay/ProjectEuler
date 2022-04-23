using System;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (long i = 2; i < 2000000; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return number == 2 ? true : false;
            }
            for (int i = 3; i < Math.Sqrt(number) + 1; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
