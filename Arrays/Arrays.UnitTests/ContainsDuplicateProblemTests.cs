using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace Arrays.UnitTests
{
    public class ContainsDuplicateProblemTests
    {
        [Fact]
        public void ContainsDuplicateHashSetDuplicateTest()
        {
            ContainsDuplicateProblem.ContainsDuplicateHashSet(new int[] { 1, 5, 3, 2, 1, 8 }).Should().BeTrue();
        }

        [Fact]
        public void ContainsDuplicateHashSetNoDuplicateTest()
        {
            ContainsDuplicateProblem.ContainsDuplicateHashSet(new int[] { 1, 5, 3, 2, 8 }).Should().BeFalse();
        }

        [Fact]
        public void ContainsDuplicateSortingDuplicateTest()
        {
            ContainsDuplicateProblem.ContainsDuplicateSorting(new int[] { 1, 5, 3, 2, 1, 8 }).Should().BeTrue();
        }

        [Fact]
        public void ContainsDuplicateSortingNoDuplicateTest()
        {
            ContainsDuplicateProblem.ContainsDuplicateSorting(new int[] { 1, 5, 3, 2, 8 }).Should().BeFalse();
        }
    }
}
