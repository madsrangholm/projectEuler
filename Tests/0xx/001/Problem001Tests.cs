using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem001;

namespace Tests._0xx._001
{
    [TestClass]
    public class Problem001Tests
    {
        [TestMethod, TestCategory("Solution")]
        public void _001Solution()
        {
            Assert.AreEqual(233168, Code.Execute());
        }
    }
}