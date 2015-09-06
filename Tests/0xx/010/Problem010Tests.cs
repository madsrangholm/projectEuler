using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem010;

namespace Tests._0xx._010
{
    [TestClass]
    public class Problem010Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _010SumOfPrime10()
        {
            var expectedResult = 17;
            var result = Code.SumOfPrimes(10);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _010Solution()
        {
            var expectedResult = 142913828922;
            var result = Code.SumOfPrimes(2000000);
            Assert.AreEqual(expectedResult, result);
        }
    }
}