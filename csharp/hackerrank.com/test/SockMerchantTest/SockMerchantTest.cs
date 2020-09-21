namespace SockMerchantTest
{
    using System;
    using Xunit;
    using SockMerchant;

    public class SockMerchantTest
    {
        [Theory]
        [InlineData(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 },3)]
        [InlineData(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 },4)]
        public void SockMerchant_should_return_3(int numberOfStocks, int[] stocks, int expected_result)
        {
            int result = Solution.sockMerchant(numberOfStocks, stocks);

            Assert.Equal(expected_result, result);
        }
    }
}
