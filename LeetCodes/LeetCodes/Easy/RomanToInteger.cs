using System;
using System.Collections.Generic;

namespace LeetCodes
{
    class RomanToInteger
    {

        public int RomanToInt(string s)
        {
            var romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            var result = 0;
            var prevValue = 0;

            for (var i = s.Length - 1; i >= 0; i--)
            {
                var currentValue = romanValues[s[i]];

                if (currentValue < prevValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }

                prevValue = currentValue;
            }

            return result;
        }

    }

}
