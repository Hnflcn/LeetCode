using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodes.Easy
{
    class RemoveDuplicatesFromSortedArray
    {
        public int[] RemoveDuplicates(int[] nums)
        {
            int k = 0; 
            foreach (int num in nums.Distinct())
            {
                nums[k] = num;
                k++;
            }

            return nums.Take(k).ToArray();
        }
    }
}
