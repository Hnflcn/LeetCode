using System;
using System.Collections.Generic;
using System.Linq;
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
            //MainForMergeTwoSortedLists();
            //MainForRemoveDuplicatesFromSortedArray();
            //MainForRemoveElement();
            MainForPalindromeNumber();
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

        private static void MainForRemoveDuplicatesFromSortedArray()
        {
            RemoveDuplicatesFromSortedArray solution = new RemoveDuplicatesFromSortedArray();

            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] result = solution.RemoveDuplicates(nums);
         //   int result = solution.RemoveDuplicates(nums);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void MainForRemoveElement()
        {
            RemoveElement solution = new RemoveElement();
            

            int[] nums1 = { 3, 2, 2, 3 };
            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            var result = solution.RmvElement(nums1, 3);
            var result2 = solution.RmvElement(nums2, 2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        private static void MainForPalindromeNumber()
        {
            PalindromeNumber solution = new PalindromeNumber();
            var value1 = 121;
            var value2 = -121;
            var value3 = 10;

            Console.WriteLine(solution.IsPalindrome(value1));
            Console.WriteLine(solution.IsPalindrome(value2));
            Console.WriteLine(solution.IsPalindrome(value3));
        }
    }
}
