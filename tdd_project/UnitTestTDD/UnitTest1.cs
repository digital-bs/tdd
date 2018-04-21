using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd_project;
using System.Collections.Generic;

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
        /*[TestMethod]
        public void TestForGetActualCity()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.AreEqual("", gameHandler.get_actualCity());
        }
        [TestMethod]
        public void TestForGetNewCity()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.AreEqual("", gameHandler.get_newCity());
        }*/
        [TestMethod]
        public void TestForSetActualCity()
        {
            GameHandler gameHandler = new GameHandler("", "");
            gameHandler.set_actualCity("city");
            Assert.AreEqual("city", gameHandler.get_actualCity());
        }
        [TestMethod]
        public void TestForSetNewCity()
        {
            GameHandler gameHandler = new GameHandler("", "");
            gameHandler.set_newCity("city");
            Assert.AreEqual("city", gameHandler.get_newCity());
        }
        [TestMethod]
        public void TestListOldCities()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.get_oldCities());
        }
        [TestMethod]
        public void TestListNewCities()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.get_newCities());
        }
        [TestMethod]
        public void TestSetterNewCitiesListFromCSV()
        {
            GameHandler gameHandler = new GameHandler("", "");
            gameHandler.loadGame();
            Assert.AreEqual("Новоалтайск", gameHandler.get_newCities()[1]);
        }
        [TestMethod]
        public void TestGetterFirstLetter()
        {
            GameHandler gameHandler = new GameHandler("", "");
            var expected = gameHandler.getFirstLetter("Новоалтацк");
            Assert.AreEqual("Н", expected);
        }


    }
}
