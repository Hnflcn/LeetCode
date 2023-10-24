using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodes.Easy
{
    class RemoveElement
    {
      //  public int RmvElement(int[] nums, int val)
      //  {
      //      var list = nums.ToList();
      //      list.RemoveAll(x => x == val);
      //      Console.WriteLine(string.Join(", ", list));
      //      return list.Count();
      //  }

        public int RmvElement(int[] nums, int val)
        {
            int k = 0;
            int length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
