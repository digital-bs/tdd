using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GameHandler gameHandler = new GameHandler();
            Assert.IsNotNull(gameHandler);
        }
    }
}
