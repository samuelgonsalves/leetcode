using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class RemoveElementProblem
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 1)
            {
                return nums[0] != val ? 1 : 0;
            }

            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else if (nums[j] != val)
                {
                    var temp = nums[i];
                    nums[i++] = nums[j];
                    nums[j] = temp;
                }
            }
            return i;
        }

        public static int RemoveElementRefactored(int[] nums, int val)
        {
            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    // no need for actual swap
                    nums[i++] = nums[j];
                }
            }
            return i;
        }
    }
}
