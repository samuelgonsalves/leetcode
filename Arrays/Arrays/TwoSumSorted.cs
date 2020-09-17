using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class TwoSumSorted
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;

            while (i < j)
            {
                int twoSum = numbers[i] + numbers[j];
                if (twoSum == target)
                    return new int[] { i + 1, j + 1 };
                else if (twoSum > target)
                    j--;
                else
                    i++;
            }

            throw new Exception("No solution exists");
        }
    }
}
