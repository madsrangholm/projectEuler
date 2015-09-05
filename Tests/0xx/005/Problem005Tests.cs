using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem005;

namespace Tests._0xx._005
{
    [TestClass]
    public class Problem005Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _005SmallestMultiple1_10()
        {
            var expectedResult = 2520;
            var result = Code.SmallestMultiple(1, 10);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _005Solution()
        {
            var expectedResult = 232792560;
            var result = Code.SmallestMultiple(1, 20);
            Assert.AreEqual(expectedResult, result);
        }
    }
}