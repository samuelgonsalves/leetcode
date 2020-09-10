using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class PlusOneProblemTests
    {
        [Fact]
        public void PlusOneTest()
        {
            PlusOneProblem.PlusOne(new int[] { 9, 1, 9 }).Should().BeEquivalentTo(new int[] { 9, 2, 0 });
        }

        [Fact]
        public void PlusOneRefactoredTest()
        {
            PlusOneProblem.PlusOneRefactored(new int[] { 9, 9, 9 }).Should().BeEquivalentTo(new int[] { 1, 0, 0, 0 });
        }
    }
}
