using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem004;

namespace Tests._0xx._004
{
    [TestClass]
    public class Problem004Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _004TestLargesPalindrome2()
        {
            var expectedResult = 9009;
            var result = Code.LargestPalindrome(2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _004Solution()
        {
            var expectedResult = 906609;
            var result = Code.LargestPalindrome(3);
            Assert.AreEqual(expectedResult, result);
        }
    }
}