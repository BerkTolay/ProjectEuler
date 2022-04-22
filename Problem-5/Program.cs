using System;
using System.Collections.Generic;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = 20;
            List<int> list = FindPrimes(20);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = Exp(list[i], upperLimit);
            }
            int result = 1;
            foreach (var item in list)
            {
                Console.Write(item + " ");
                result *= item;
            }
            Console.WriteLine("\n" + result);
        }
        static List<int> FindPrimes(int x)
        {
            List<int> list = new();
            for (int i = 2; i < 20; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public static bool IsPrime(int number)
        {

            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return number == 2 ? true : false;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prime">prime number</param>
        /// <param name="limit">upper limit</param>
        /// <returns></returns>
        public static int Exp(int prime, int limit)
        {
            int counter = 0;
            int primeExp = 1;
            for (int i = 1; primeExp < limit; i++)
            {
                if (i * prime < limit)
                {
                    primeExp *= prime;
                    counter++;
                }
            }
            return primeExp / prime;
        }
    }
}
