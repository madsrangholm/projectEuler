using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem007;

namespace Tests._0xx._007
{
    [TestClass]
    public class Problem007Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _007FindPrime6()
        {
            var expectedResult = 13;
            var result = Code.FindPrime(6);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _007Solution()
        {
            var expectedResult = 104743;
            var result = Code.FindPrime(10001);
            Assert.AreEqual(expectedResult, result);
        }
    }
}