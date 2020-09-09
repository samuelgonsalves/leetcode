using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class MergeSortedArraysTests
    {
        [Fact]
        public void MergeTest()
        {
            var nums1 = new int[] { 1, 4, 6, 7, 9, 0, 0, 0, 0 };
            var nums2 = new int[] { 2, 3, 8, 10 };

            MergeSortedArrays.Merge(nums1, nums1.Length - nums2.Length, nums2, nums2.Length).Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 });
        }
    }
}
