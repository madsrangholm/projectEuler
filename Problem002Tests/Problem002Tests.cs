using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem002Tests
{
    [TestClass]
    public class Problem002Tests
    {
        [TestMethod]
        public void TestProblem002()
        {
            Assert.AreEqual(4613732,Problem002.Problem002.Execute());
        }
    }
}
