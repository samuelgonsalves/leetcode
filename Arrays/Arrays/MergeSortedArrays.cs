using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class MergeSortedArrays
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int t = m + n - 1, i = m - 1, j = n - 1; t >= 0; t--)
            {
                if (i < 0)
                {
                    nums1[t] = nums2[j--];
                }
                else if (j < 0)
                {
                    nums1[t] = nums1[i--];
                }
                else
                {
                    if (nums1[i] > nums2[j])
                    {
                        nums1[t] = nums1[i--];
                    }
                    else
                    {
                        nums1[t] = nums2[j--];
                    }
                }
            }

            return nums1;
        }

    }
}
