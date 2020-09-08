using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class RemoveElementProblemTests
    {
        [Fact]
        public void RemoveElementTest()
        {
            var lengthOfListWithRemovedElement = RemoveElementProblem.RemoveElement(new int[] { 1, 2, 2, 3, 5 }, 2);

            lengthOfListWithRemovedElement.Should().Be(3);

        }
    }
}
