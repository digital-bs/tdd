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
            Player player = new Player("програмуктер");
            string name;
            name = player.getName();
            Assert.AreEqual(name, "програмуктер");
        }
        
        [TestMethod]
        public void TestPlayerPoints()
        {
            Player player = new Player("програмуктер");
            int points = player.getPoints();
            Assert.AreEqual(points, 0);
        }
        [TestMethod]
        public void TestGameConstructorWithNames()
        {
            GameHandler gameHandler = new GameHandler("","");
            Assert.IsNotNull(gameHandler);
        }
    }
}
