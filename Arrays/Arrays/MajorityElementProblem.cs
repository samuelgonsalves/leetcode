using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class MajorityElementProblem
    {
        public static int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int limit = nums.Length / 2;

            if (limit == 0)
                return nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                var element = nums[i];

                if (dict.ContainsKey(element))
                {
                    if (++dict[element] > limit)
                        return element;
                }
                else
                {
                    dict.Add(element, 1);
                }
            }

            throw new Exception("No majority element exists.");
        }
    }
}
