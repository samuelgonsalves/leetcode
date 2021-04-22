using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class MaxConsecutiveOnesTests
    {
        [Fact]
        public void MaxConsecutiveOnesTest()
        {
            MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 1, 2, 3, 1, 1, 1, 2, 1, 4 }).Should().Be(3);
        }
    }
}
