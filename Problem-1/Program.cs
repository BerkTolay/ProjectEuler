using System;
using System.Collections.Generic;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1000;
            int sum = 0;
            List<int> list = new();
            for (int i = 0; i < value; i += 3)
            {
                sum += i;
                list.Add(i);
            }

            for (int i = 0; i < value; i += 5)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                sum += i;
                list.Add(i);
            }
            list.Sort();
            Console.WriteLine(sum);
            // Console.WriteLine(sum + "\n");
            // foreach (int item in list)
            // {
            //     Console.Write(item + " ");
            // }
        }
    }
}
