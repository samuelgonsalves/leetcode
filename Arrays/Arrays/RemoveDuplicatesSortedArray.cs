using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class RemoveDuplicatesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;

            if (length == 0)
                return length;

            int i = 0;
            
            // j keeps moving right
            // If there's a different number from i, we replace the i + 1 th element with j element and increment i
            // This is because i tracks the no-duplicates list to be returned, j skips over duplicates and gets first non duplicate
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    nums[++i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
