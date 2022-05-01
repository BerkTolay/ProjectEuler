using System;
using System.Numerics;
namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger row = 20;
            BigInteger column = 20;
            BigInteger result = Fact(row + column) / (Fact(row) * Fact(column));
            Console.WriteLine(result);
        }
        public static BigInteger Fact(BigInteger number)
        {
            BigInteger sum = 1;
            while (number > 0)
            {
                sum *= number;
                number--;
            }
            return sum;
        }
    }
}
