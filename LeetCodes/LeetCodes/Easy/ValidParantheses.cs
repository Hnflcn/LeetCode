using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodes.Easy
{
    class ValidParantheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
                return false;

            var stack = new Stack<char>();

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
