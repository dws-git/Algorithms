using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Tests
{
    public class BinaryGapTests
    {
        private readonly ITestOutputHelper output;

        public BinaryGapTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(529, 4)]
        [InlineData(8, 0)]
        [InlineData(1041, 5)]
        [InlineData(Int32.MaxValue, 0)]
        public void FindLongestSequenceOfZerosCharArray(int number, int expectedResult)
        {
            BinaryGap algorithm = new BinaryGap();
            int longestSequenceOfZeros = algorithm.FindLongestSequenceOfZerosCharArray(number);
            Assert.Equal(expectedResult, longestSequenceOfZeros);
        }

        [Theory]
        [InlineData(529, 4)]
        [InlineData(8, 0)]
        [InlineData(1041, 5)]
        [InlineData(Int32.MaxValue, 0)]
        public void FindLongestSequenceOfZerosBitShift(int number, int expectedResult)
        {
            BinaryGap algorithm = new BinaryGap();
            int longestSequenceOfZeros = algorithm.FindLongestSequenceOfZerosBitShift(number);
            Assert.Equal(expectedResult, longestSequenceOfZeros);
        }
    }
}
