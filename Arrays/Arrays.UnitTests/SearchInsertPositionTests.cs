using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class SearchInsertPositionTests
    {
        [Fact]
        public void SearchInsertRecursiveTest()
        {
            var array = new int[] { 1, 4, 5, 7, 8 };
            var target = 6;

            SearchInsertPositionProblem.SearchInsertRecursive(array, target).Should().Be(3);
        }

        [Fact]
        public void SearchInsertIterativeTest()
        {
            var array = new int[] { 1, 4, 5, 7, 8 };
            var target = 9;

            SearchInsertPositionProblem.SearchInsertIterative(array, target).Should().Be(5);
        }
    }
}
