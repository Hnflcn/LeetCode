using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes.Easy
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            // 0 dan küçük palindrome olamayacağı için küçükleri direkt ele
            if (x < 0)
            {
                return false;
            }

            var numStr = x.ToString();
            var n = numStr.Length;

            for (var i = 0; i < n / 2; i++)
            {
                if (numStr[i] != numStr[n - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
