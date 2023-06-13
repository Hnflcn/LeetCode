using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodes
{
    class LongestCommonPrefix
    {
        public string LongestCommonPref(string[] strs)
        {
            var stringWord = "";

            if (strs.Length == 0)
                return stringWord;

            var minLen = strs.Min(s => s.Length);

            for (var i = 0; i < minLen; i++)
            {
                var currentChar = strs[0][i];

                if (strs.All(s => s[i] == currentChar))
                    stringWord += currentChar;
                else
                    break;
            }

            return stringWord;
        }


    }
}
