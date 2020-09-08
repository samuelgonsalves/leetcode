using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace Arrays.UnitTests
{
    public class RemoveDuplicatesSortedArrayTests
    {
        [Fact]
        public void RemoveDuplicatesTest()
        {
            var lengthOfNonDuplicateList = RemoveDuplicatesSortedArray.RemoveDuplicates(new int[] { 1, 2, 2, 3 , 5 });

            lengthOfNonDuplicateList.Should().Be(4);
        }
    }
}
