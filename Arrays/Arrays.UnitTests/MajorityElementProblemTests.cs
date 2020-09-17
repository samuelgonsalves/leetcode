using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Arrays.UnitTests
{
    public class MajorityElementProblemTests
    {
        [Fact]
        public void MajorityElementProblemTest()
        {
            MajorityElementProblem.MajorityElement(new int[] { 1, 2, 1, 1, 2, 2, 2 }).Should().Be(2); 
        }

    }
}
