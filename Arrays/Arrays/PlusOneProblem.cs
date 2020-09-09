using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class PlusOneProblem
    {
        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;

            if (digits[i] == 9)
            {
                while (i >= 0)
                {
                    digits[i] = (digits[i] + 1) % 10;
                    if (digits[i] != 0)
                        break;
                    i--;
                }

                if (digits[0] == 0)
                {
                    var overflowed = new int[digits.Length + 1];

                    overflowed[0] = 1;
                    for (int j = 1; j < overflowed.Length; j++)
                    {
                        overflowed[j] = digits[j - 1];
                    }

                    return overflowed;
                }
            }
            else
            {
                digits[i] += 1;
            }

            return digits;
        }

        public static int[] PlusOneRefactored(int[] digits)
        {
            int i = digits.Length - 1;

            // Just need to find where 9s stop 
            while (i >= 0 && digits[i] == 9)
            {
                digits[i] = 0;
                i--;
            }
            // 9s never stop for entire array (overflow case)
            if (i < 0)
            {
                var overflowed = new int[digits.Length + 1];

                overflowed[0] = 1;
                for (int j = 1; j < overflowed.Length; j++)
                {
                    overflowed[j] = digits[j - 1];
                }

                return overflowed;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }

    }
}
