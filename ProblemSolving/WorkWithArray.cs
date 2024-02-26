using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    internal static class WorkWithArray
    {
        internal static IEnumerable<int> MissingElements(int[] arr)
        {
            var result = new List<int>();
            var sortedArr = arr.OrderBy(a => a).ToList();
            var sortedArrLenght = sortedArr.Count;
            for (int i = 0; i < sortedArrLenght; i++)
            {
                if (i > 0 && (sortedArr[i] - sortedArr[i-1] > 1))
                {
                    var different = sortedArr[i] - sortedArr[i - 1];
                    for (int j = 1; j < different; j++)
                    {
                        var missElement = sortedArr[i-1] + j;
                        result.Add(missElement);
                    }
                }
            }
            return result;
        }
    }
}
