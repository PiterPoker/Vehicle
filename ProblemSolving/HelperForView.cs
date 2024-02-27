using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    internal static class HelperForView
    {
        #region 4.1
        internal static string[] InitArrayReverseString()
        {
            return new string[]
            {
                "Contrary to popular belief",
                "Richard McClintock",
                "Hello World!"
            };
        }

        internal static void RunReverseString()
        {
            foreach (var item in InitArrayReverseString())
            {
                var result = WorkWithStrings.ReverseString(item);

                Console.WriteLine($"{item} -> {result} \n");
            }
        }

        #endregion

        #region 4.2
        internal static string[] InitArrayDetectPalindrome()
        {
            return new string[]
            {
                "madam",
                "was it a car or a cat I saw",
                "Hello World!"
            };
        }

        internal static void RunDetectPalindrome()
        {
            foreach (var item in InitArrayDetectPalindrome())
            {
                if (WorkWithStrings.IsPalindrome(item))
                {
                    Console.Write($"Yes! String \"{item}\" is palindrome\n");
                }
                else
                {
                    Console.Write($"No! String \"{item}\" is not palindrome\n");
                }
            }
        }
        #endregion

        #region 4.3
        internal static int[][] InitArrayShearchForMissingElements()
        {
            int[][] arrays = new int [3][];
            arrays[0] = new int[] { 4, 6, 9 };
            arrays[1] = new int[] { 2, 3, 4 };
            arrays[2] = new int[] { 1, 3, 4 };
            return arrays;
        }

        internal static void RunShearchForMissingElements()
        {
            foreach (var array in InitArrayShearchForMissingElements())
            {
                var arrayString = string.Empty;
                foreach (var item in array)
                {
                    arrayString += $" {item} ";
                }
                var result = WorkWithArray.MissingElements(array);
                var resultString = string.Empty;
                foreach (var item in result)
                {
                    resultString += $" {item} ";
                }
                Console.WriteLine($"main array[{arrayString}] missing elements array[{resultString}]");
            }
        }
        #endregion
    }
}
