namespace SockMerchantTest
{
    using System;
    using Xunit;
    using SockMerchant;

    public class SockMerchantTest
    {
        [Fact]
        public void SockMerchant_should_return_3()
        {
            int numberOfStocks = 9;
            int[] stocks = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int expected_result = 3;

            int result = Solution.sockMerchant(numberOfStocks, stocks);

            Assert.Equal(expected_result, result);
        }

        [Fact]
        public void SockMerchant_should_return_4()
        {
            int numberOfStocks = 10;
            int[] stocks = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            int expected_result = 4;

            int result = Solution.sockMerchant(numberOfStocks, stocks);

            Assert.Equal(expected_result, result);
        }

    }
}
