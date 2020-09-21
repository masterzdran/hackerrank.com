using JumpingOnTheClouds;
using System;
using Xunit;

namespace JumpingOnTheCloudsTest
{
    public class JumpingOnTheCloudsTests
    {
        [Theory]
        [InlineData(7, new int[] { 0, 0, 1, 0, 0, 1, 0 },4)]
        [InlineData(6, new int[] { 0, 0, 0, 0, 1, 0 },3)]
        [InlineData(6, new int[] { 0, 0, 0, 1, 0, 0 },3)]
        public void jumpingOnClouds_should_return_true(int n, int[] c, int expected_result)
        {
            int result = Solution.jumpingOnClouds(c);
            Assert.Equal(expected_result, result);
        }
    }
}
