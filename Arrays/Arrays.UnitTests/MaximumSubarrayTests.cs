using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace Arrays.UnitTests
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void MaxSubarrayTest()
        {
            var maxSubarrayValue = MaximumSubarray.MaxSubArray(new int[] { -1, 2, -1, 3 , -2 });

            maxSubarrayValue.Should().Be(4);
        }

        [Fact]
        public void MaxSubarrayKadanesTest()
        {
            var maxSubarrayValue = MaximumSubarray.MaxSubArrayKadanes(new int[] { -1, 2, -1, 3, 1, -2 });

            maxSubarrayValue.Should().Be(5);
        }
    }
}
