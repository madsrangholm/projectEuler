using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem017;

namespace Tests._0xx._017
{
    [TestClass]
    public class Problem017Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _017LetterCountSum1_5()
        {
            var expectedResult = 19;
            var result = Code.LetterCountSum(1, 5);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod, TestCategory("Assumption")]
        public void _017LetterCount342()
        {
            var expectedResult = 23;
            var result = Code.LetterCount(342);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod, TestCategory("Assumption")]
        public void _017LetterCount115()
        {
            var expectedResult = 20;
            var result = Code.LetterCount(115);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, TestCategory("Solution")]
        public void _017Solution()
        {
            var expectedResult = 21124;
            var result = Code.LetterCountSum(1,1000);
            Assert.AreEqual(expectedResult, result);
        }
    }
}