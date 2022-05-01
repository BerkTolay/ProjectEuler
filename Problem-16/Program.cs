using System;
using System.Numerics;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Pow(2, 1000);
            int sum = 0;
            while (number > 0)
            {
                sum += (int)(number % 10);
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
