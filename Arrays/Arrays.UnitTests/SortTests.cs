using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class SortTests
    {
        [Fact]
        public void MergeSortTest()
        {
            Sort.MergeSort(new int[] { 1, 3, 7, 8, 2 }).Should().BeEquivalentTo(new int[] { 1, 2, 3, 7, 8 });
        }
    }
}
