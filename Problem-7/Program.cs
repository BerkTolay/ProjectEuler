using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int result = 0;
            for (int i = 2; counter < 10001; i++)
            {
                if (IsPrime(i))
                {
                    result = i;
                    counter++;
                }
            }
            Console.WriteLine(result);
        }
        static bool IsPrime(int number)
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
                {
                    return false;
                }
            }
            return true;
        }
    }
}
