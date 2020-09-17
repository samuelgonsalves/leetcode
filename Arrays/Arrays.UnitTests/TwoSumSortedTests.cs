using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class TwoSumSortedTests
    {
        [Fact]
        public void TwoSumSortedTest()
        {
            TwoSumSorted.TwoSum(new int[] { 1, 4, 6, 8 }, 12).Should().BeEquivalentTo(new int[] { 2, 4 });
        }
    }
}
