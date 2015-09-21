using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem015;

namespace Tests._0xx._015
{
    [TestClass]
    public class Problem015Tests
    {
        [TestMethod, TestCategory("Assumption")]
        public void _015LatticePaths2_2()
        {
            var expectedResult = 6;
            var result = Code.LatticeRoutes(2,2);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod, TestCategory("Solution")]
        public void _015Solution()
        {
            var expectedResult = 137846528820;
            var result = Code.LatticeRoutes(20, 20);
            Assert.AreEqual(expectedResult, result);
        }
    }
}