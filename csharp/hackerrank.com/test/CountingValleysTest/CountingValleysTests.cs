using System;
using Xunit;

namespace CountingValleysTest
{
    public class CountingValleysTests
    {
        [Fact]
        public void CountingValleys_Should_Return_1()
        {
            int n = 8;
            string s = "UDDDUDUU";
            int expected_result = 1;
            int result = Solution.countingValleys(n, s);

            Assert.Equal(expected_result,result);
        }

        [Fact]
        public void CountingValleys_Should_Return_2()
        {
            int n = 12;
            string s = "DDUUDDUDUUUD";
            int expected_result = 2;
            int result = Solution.countingValleys(n, s);

            Assert.Equal(expected_result, result);
        }

        [Fact]
        public void CountingValleys_Should_Return_3()
        {
            int n = 24;
            string s = "UDDDUDUUUDDDUDUUUDDDUDUU";
            int expected_result = 3;
            int result = Solution.countingValleys(n, s);

            Assert.Equal(expected_result, result);
        }
    }
}
