using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxSum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    count++;
                else
                {
                    if (count != 0)
                    {
                        count = 0;
                    }
                }

                if (count > maxSum)
                    maxSum = count;
            }

            return maxSum;
        }
    }
}
