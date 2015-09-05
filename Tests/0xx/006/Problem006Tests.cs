using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem006;

namespace Tests._0xx._006
{
    [TestClass]
    public class Problem006Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _006SumSquareDifference1_10()
        {
            var expectedResult = 2640;
            var result = Code.SumSquareDifference(1, 10);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _006Solution()
        {
            var expectedResult = 25164150;
            var result = Code.SumSquareDifference(1, 100);
            Assert.AreEqual(expectedResult, result);
        }
    }
}