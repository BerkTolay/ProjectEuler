using System;
using System.Collections.Generic;
namespace Problem_14
{
    class Program
    {
        internal static Dictionary<ulong, ulong> dictionary = new Dictionary<ulong, ulong>
        {
            {1 , 1},
            {2 , 2}
        };
        //!!!!!Optimize edilecek!!!!!!
        static void Main(string[] args)
        {
            ulong aranan = 1;
            ulong max = 1;
            for (ulong i = 3; i <= 1000000; i++)
            {
                ulong count = Collatz(i);
                if (count > max)
                {
                    max = count;
                    aranan = i;
                }
            }
            Console.WriteLine("{0} {1}",aranan,max);
            
        }

        static ulong Collatz(ulong number)
        {
            ulong numberReserve = number;
            ulong count = 1;
            
            while (number > 1)
            {
                if (dictionary.ContainsKey(number))
                {
                    ulong value;
                    dictionary.TryGetValue(number, out value);
                    count += value - 1;
                    break;
                }

                if (number % 2 == 0)
                {
                    number /= 2;
                    count++;
                }
                else
                {
                    number = 3 * number + 1;
                    count++;
                }

            }
            dictionary.Add(numberReserve, count);
            return count;

        }
    }
}



    

