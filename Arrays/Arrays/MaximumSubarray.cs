using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (maxSum < sum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }

        public static int MaxSubArrayKadanes(int[] nums)
        {
            int maxSum = nums[0], maxTillPrevious = nums[0];

            // Only need to check maximum of current element, and previous maximum, while keeping track of global max (maxSum)
            for (int i = 1; i < nums.Length; i++)
            {
                maxTillPrevious = Math.Max(nums[i], nums[i] + maxTillPrevious);
                if (maxTillPrevious > maxSum)
                    maxSum = maxTillPrevious;
            }

            return maxSum;
        }
    }
}
