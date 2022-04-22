using System;
using System.Collections.Generic;
using System.Linq;

//You can only walk over NON PRIME NUMBERS.

namespace Problem_18
{
    class Program
    {

        public static string Input =
                                @"215
                                193 124
                                117 237 442
                                218 935 347 235
                                320 804 522 417 345
                                229 601 723 835 133 124
                                248 202 277 433 207 263 257
                                359 464 504 528 516 716 871 182
                                461 441 426 656 863 560 380 171 923
                                381 348 573 533 447 632 387 176 975 449
                                223 711 445 645 245 543 931 532 937 541 444
                                330 131 333 928 377 733 017 778 839 168 197 197
                                131 171 522 137 217 224 291 413 528 520 227 229 928
                                223 626 034 683 839 053 627 310 713 999 629 817 410 121
                                924 622 911 233 325 139 721 218 253 223 107 233 230 124 233";
        static void Main(string[] args)
        {
            var input = TriangleTo2DArray(Input);
            var inputIncludedPrimes = TriangleTo2DArray(Input,true);
            var result = FindMaxValueByTheRule(input);

            int[,] pathCheck = new int[inputIncludedPrimes.GetLength(0), inputIncludedPrimes.GetLength(1)];

            var foundPath = FindPath(pathCheck, result, inputIncludedPrimes);
            PrintPath(inputIncludedPrimes, foundPath);
            
            Console.WriteLine(Environment.NewLine + "Max Value By The Rules {0}",result[0,0]);

        }
        /// <summary>
        /// Convert a string to a 2-dimensional array of integers
        /// </summary>
        /// <param name="input"></param>
        /// <param name="predicate">send true if you don't want prime numbers to be replaced by negative numbers</param>
        /// <returns></returns>
        public static int[,] TriangleTo2DArray(string input,bool predicate=false)
        {
            int rowCount = 0;
            int columnCount = 0;

            var result = new List<string>(Input.Split('\n'));

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = result[i].TrimStart().TrimEnd();

            }

            rowCount = result.Count;

            columnCount = result[result.Count - 1].Split(' ').Length;

            int[,] OutputArray = new int[rowCount, columnCount + 1];

            

            for (int ResultRow = 0; ResultRow < result.Count; ResultRow++)
            {
                var tmpArr = result[ResultRow].Split(' ');

                if (predicate)
                {
                    for (int i = 0; i < tmpArr.Length; i++)
                    {
                        OutputArray[ResultRow, i] = int.Parse(tmpArr[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < tmpArr.Length; i++)
                    {
                        OutputArray[ResultRow, i] = int.Parse(tmpArr[i]).IsPrime() ? -1000000 : int.Parse(tmpArr[i]);
                    }
                }
            }
            return OutputArray;
        }
       
        public static int[,] FindMaxValueByTheRule(int[,] input)
        {

            int k = input.GetLength(0) - 2;
            while (k > -1)
            {
                int m = 0;
                while (m < k + 1)
                {
                    input[k, m] = Math.Max((input[k + 1, m] + input[k, m]), (input[k, m] + input[k + 1, m + 1]));
                    m += 1;
                }

                k -= 1;
            }
            return input;
        }
        public static int[,] FindPath(int[,] pathCheck, int[,] result, int[,] input)
        {
            pathCheck[0, 0] = 1;
            int i = 1, j = 0;
            while (i < (CustomArray.GetRow(result, i)).Length)
            {
                if (result[i - 1, j] == result[i, j] + input[i - 1, j])
                {
                    pathCheck[i, j] = 1;
                }
                else
                {
                    pathCheck[i, j + 1] = 1;
                    j = j + 1;
                }

                i += 1;
            }

            return pathCheck;
        }
        public static void PrintPath(int[,] Path, int[,] foundPath)
        {
            int i = 0;
            while (i < CustomArray.GetRow(Path, i).Length)
            {
                int j = 0;
                while (j < (CustomArray.GetRow(Path, i).Length) - i + 1)
                {
                    Console.Write("  ");
                    j += 1;
                }
                j = 0;
                while (j < (CustomArray.GetColumn(Path, i).Length))
                {
                   
                    if (foundPath[i, j] == 0)
                    {
                        if (Path[i, j] != 0)
                        {
                            Console.Write("{0} ", Path[i, j]);
                        }

                    }
                    else
                    {
                        Console.Write("*{0}* ", Path[i, j]);
                    }

                    j += 1;
                }

                Console.WriteLine();
                i += 1;
            }
        }
        
    }
    /// <summary>
    /// get rows or columns as array
    /// </summary>
    public static class CustomArray
    {
        public static int[] GetColumn(int[,] matrix, int columnNumber)
        {
            
                return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static int[] GetRow(int[,] matrix, int rowNumber)
        {
            //the problem here should be fixed
            try
            {
                return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
            }
            catch
            {
                return new int[] { };
            }

        }
    }

    public static class MyExtentionsMethods
    {
        public static bool IsPrime(this int number)
        {

            
            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return number==2 ? true : false;
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
    }
}