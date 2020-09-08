using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class SearchInsertPositionProblem
    {
        public static int SearchInsertRecursive(int[] nums, int target)
        {
            // Messed up the j index here (nums.Length)
            return binarySearch(nums, 0, nums.Length - 1, target);
        }

        public static int SearchInsertIterative(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1;

            while (i <= j)
            {
                int m = i + (j - i)/2; // i + offset for midpoint (needed to prevent an overflow for very large arrays)

                if (nums[m] == target)
                    return m;
                else if (nums[m] > target)
                {
                    j = m - 1;
                }
                else if (nums[m] < target)
                {
                    i = m + 1;
                }
            }
            return i;
        }

        private static int binarySearch(int[] nums, int i, int j, int target)
        {
            // Couldn't figure out what the termination/overflow case was
            if (i > j)
                return i;

            int m = i + (j - i) / 2;

            if (nums[m] == target)
                return m;
            else if (nums[m] < target)
                return binarySearch(nums, m + 1, j, target); // Forgot to add returns in each of these conditions
            else
                return binarySearch(nums, i, m - 1, target);
        }

    }
}
