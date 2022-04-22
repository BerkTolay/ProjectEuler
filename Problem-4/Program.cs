using System;
using System.Collections.Generic;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new();
            int value = 0;
            int previous = 0;
            for (int j = 999; j > 100; j--)
            {
                for (int i = 999; i >= j; i--)
                {
                    if (IsPalindrome(j * i) == 0)
                    {
                        previous = i * j;
                        if (previous > value)
                        {
                            value = previous;
                        }
                    }
                }
            }

            Console.WriteLine(value);

        }
        static int IsPalindrome(int x)
        {
            string number = x.ToString();
            char[] charArray = number.ToCharArray();
            string reversedNumber = string.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedNumber += charArray[i];
            }
            int result = string.Compare(number, reversedNumber);
            return result;
        }
        /// <summary>
        /// alternative
        /// </summary>
        static int IsPalindrome2(int x)
        {
            int reservedNumber = 0;
            int remainder = 0;
            while (x != 0)
            {
                remainder = x % 10;
                reservedNumber = reservedNumber * 10 + remainder;
                x /= 10;
            }
            return reservedNumber;
        }

    }
}
