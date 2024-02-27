using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    internal class WorkWithStrings
    {
        #region 4.1
        internal static string ReverseString(string s)
        {
            var sArray = s.ToCharArray();
            var sLength = sArray.Length - 1;
            for (int i = 0; i < sArray.Length / 2; i++)
            {
                int j = sLength - i;
                var value = sArray[i];
                sArray[i] = sArray[j];
                sArray[j] = value;
            }
            return new string(sArray);
        }

        #endregion

        #region 4.2
        internal static bool IsPalindrome(string s)
        {
            var sArray = s.Replace(" ", string.Empty)
                .ToUpper()
                .ToCharArray();
            var sLength = sArray.Length - 1;
            for (int i = 0; i < sArray.Length / 2; i++)
            {
                int j = sLength - i;

                if (sArray[i] != sArray[j])
                    return false;
            }
            return true;
        }
        #endregion
    }
}
