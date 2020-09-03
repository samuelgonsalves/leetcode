using System;
using System.Collections.Generic;

namespace Arrays
{
    public static class TwoSumProblem
    {
            public static int[] TwoSum(int[] nums, int target)
            {
                var dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    var key = target - nums[i];

                    if (dict.ContainsKey(key))
                        return new int[] { i, dict[key] };

                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }

                throw new Exception("Exactly one solution does not exist");
            }
        }

}
