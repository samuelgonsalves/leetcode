using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace Arrays.UnitTests
{
    public class TwoSumProblemTests
    {
        [Fact]
        public void Test1()
        {
            var result = TwoSumProblem.TwoSum(new int[] { 6, 1, -1, 5, -6 }, -7);

            result.ToList().Should().Contain(new int[] { 2, 4 });
        }
    }
}
