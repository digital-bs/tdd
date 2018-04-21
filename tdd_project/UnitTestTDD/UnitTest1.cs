using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd_project;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGameHandler()
        {
            GameHandler gameHandler = new GameHandler();
            Assert.IsNotNull(gameHandler);
        }
        [TestMethod]
        public void TestPlayerCreate()
        {
            Player player = new Player();
            Assert.IsNotNull(player);
        }
        [TestMethod]
        public void TestPlayerCreateWithName()
        {
            string name;
            Player player = new Player("програмуктер");
            name = player.getName();
            Assert.AreEqual(name, "програмуктер");
        }
    }
}
