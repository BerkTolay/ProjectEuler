using System;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            bool flag = false;
            for (int i = 3; i < 1000; i++)
            {
                for (int j = 4; j < 1000 - i; j++)
                {
                    k = 1000 - i - j;
                    if (Math.Pow(k, 2) == Math.Pow(i, 2) + Math.Pow(j, 2))
                    {
                        Console.WriteLine("{0} {1} {2}", i, j, k);
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                    break;
            }
        }
    }
}
