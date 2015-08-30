using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem001Tests
{
    [TestClass]
    public class Problem001Tests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(233168, Problem001.Code.Execute());
        }
    }
}
