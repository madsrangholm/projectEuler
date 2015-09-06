using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem009;

namespace Tests._0xx._009
{
    [TestClass]
    public class Problem009Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _008PytagorianTriplet3_4_5()
        {
            var expectedResult = 60;
            var result = Code.PytagorianTripletProduct(12);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _009Solution()
        {
            var expectedResult = 31875000;
            var result = Code.PytagorianTripletProduct(1000);
            Assert.AreEqual(expectedResult, result);
        }
    }
}