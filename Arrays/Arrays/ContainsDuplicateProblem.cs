using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class ContainsDuplicateProblem
    {
        public static bool ContainsDuplicateHashSet(int[] nums)
        {
            // Initially used dictionary and forgot about hashsets
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Retrieval of a value throws an exception if not exists
                if (!set.Contains(nums[i]))
                    set.Add(nums[i]);
                else
                    return true;
            }
            return false;
        }

        public static bool ContainsDuplicateSorting(int[] nums)
        {
            if (nums.Length == 1)
                return false;

            Array.Sort(nums);

            for (int i = 0, j = 1; j < nums.Length; i++, j++)
            {
                // Should end up adjacent if duplicate
                if (nums[i] == nums[j])
                    return true;
            }
            return false;
        }
    }
}
