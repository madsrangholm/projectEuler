using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem002;

namespace Tests._0xx._002
{
    [TestClass]
    public class Problem002Tests
    {
        [TestMethod, TestCategory("Solution")]
        public void _002Solution()
        {
            Assert.AreEqual(4613732, Code.Execute());
        }
    }
}