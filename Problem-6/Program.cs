using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, sumSquare = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                sumSquare += i * i;
            }
            Console.WriteLine((Math.Pow(sum, 2)) - sumSquare);
        }
    }
}
