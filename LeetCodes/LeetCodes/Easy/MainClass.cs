using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes.Easy
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //MainForLongestCommonPrefix();
            //MainForRomanToInteger();
            //MainForValidParantheses();
            MainForMergeTwoSortedLists();
        }


        private static void MainForLongestCommonPrefix()
        {
            LongestCommonPrefix solution = new LongestCommonPrefix();
            string[] input = { "flower", "flow", "flight" };
            var result = solution.LongestCommonPref(input);
            Console.WriteLine(result);
        }
        private static void MainForRomanToInteger()
        {
            RomanToInteger solution = new RomanToInteger();
            var romanNumeral = "XXIV";
            var result = solution.RomanToInt(romanNumeral);
            Console.WriteLine("result: " + result);
        }

        private static void MainForValidParantheses()
        {
            ValidParantheses solution = new ValidParantheses();
            var result1 = solution.IsValid("()");
            var result2 = solution.IsValid("()[]{}");
            var result3 = solution.IsValid("(]");

            Console.WriteLine("result1: " + result1 + "    result2: " + result2  + "    result3: " + result3);

            //3.225.783
        }

        private static void MainForMergeTwoSortedLists()
        {
            MergeTwoSortedLists solution = new MergeTwoSortedLists();

            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var mergeList = solution.MergeTwoLists(list1, list2);
            PrintNode.PrintList(mergeList);
        }

    }
}
