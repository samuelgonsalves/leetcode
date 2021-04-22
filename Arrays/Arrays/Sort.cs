using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class Sort
    {
        public static int[] MergeSort(int[] unsortedArray)
        {
            return Merge(unsortedArray, 0, unsortedArray.Length - 1);
        }

        private static int[] Merge(int[] array, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                // Divide phase
                return Combine(Merge(array, lo, mid), Merge(array, mid+1, hi));
            }
            else if (lo == hi)
            {
                return new int[] { array[lo] };
            }
            return new int[] { };
        }

        private static int[] Combine(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0)
                return arr2;
            else if (arr2.Length == 0)
                return arr1;

            var result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0;

            for (int k = 0; k < result.Length; k++)
            {
                int min = int.MaxValue;
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] > arr2[j])
                    {
                        min = arr2[j];
                        j++;
                    }
                    else
                    {
                        min = arr1[i];
                        i++;
                    }
                }
                else if (i < arr1.Length)
                {
                    min = arr1[i];
                    i++;
                }
                else
                {
                    min = arr2[j];
                    j++;
                }

                result[k] = min;
            }

            return result;
        }
    }
}
