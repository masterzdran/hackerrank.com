using System;
using Xunit;

namespace CountingValleysTest
{
    public class CountingValleysTests
    {
        [Theory]
        [InlineData(8, "UDDDUDUU",1)]
        [InlineData(12, "DDUUDDUDUUUD", 2)]
        [InlineData(24, "UDDDUDUUUDDDUDUUUDDDUDUU", 3)]
        public void CountingValleys_Should_Return_Return_True(int n,string s, int expected_result)
        {
            int result = Solution.countingValleys(n, s);

            Assert.Equal(expected_result,result);
        }
    }
}
