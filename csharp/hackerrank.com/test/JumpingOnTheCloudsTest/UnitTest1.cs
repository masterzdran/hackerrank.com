using JumpingOnTheClouds;
using System;
using Xunit;

namespace JumpingOnTheCloudsTest
{
    public class JumpingOnTheCloudsTests
    {
        [Fact]
        public void jumpingOnClouds_should_return_4()
        {
            int n = 7;
            int[] c = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            int expected_result = 4;

            int result = Solution.jumpingOnClouds(c);
            Assert.Equal(expected_result, result);
        }

        [Fact]
        public void jumpingOnClouds_should_return_3()
        {
            int n = 6;
            int[] c = new int[] { 0, 0, 0, 0, 1, 0 };
            int expected_result = 3;

            int result = Solution.jumpingOnClouds(c);
            Assert.Equal(expected_result, result);
        }
        [Fact]
        public void jumpingOnClouds_should_return_also_3()
        {
            int n = 6;
            int[] c = new int[] { 0, 0, 0, 1, 0, 0 };
            int expected_result = 3;

            int result = Solution.jumpingOnClouds(c);
            Assert.Equal(expected_result, result);
        }
    }
}
