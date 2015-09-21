using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem003;

namespace Tests._0xx._003
{
    [TestClass]
    public class Problem003Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _003PrimeFactor13195()
        {
            var expectedResult = 29;
            var result = Code.BiggestPrimeFactor(13195);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _003Solution()
        {
            var expectedResult = 6857;
            var result = Code.BiggestPrimeFactor(600851475143);
            Assert.AreEqual(expectedResult, result);
        }
    }
}