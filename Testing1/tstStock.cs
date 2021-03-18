using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        int productId = 1;
        string GameTitle = "Devil May Cry";
        string Price = "12.99";
        string Platform = "Playstation 4";
        string StockQuantity = "2";
        string ReleaseDate = "01/01/15";


        [TestMethod]
        public void instanceOK()
        {
            clsStock Game = new clsStock();

            Assert.IsNotNull(Game);
        }

        [TestMethod]
        public void productIdOK()
        {
            clsStock Game = new clsStock();

            int StockData = 1234;

            Game.productId = StockData;

            Assert.AreEqual(StockData, Game.productId);
        }

        [TestMethod]
        public void GameTitleOK()
        {
            clsStock Game = new clsStock();

            string StockData = "Fallout";

            Game.GameTitle = StockData;

            Assert.AreEqual(StockData, Game.GameTitle);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsStock Game = new clsStock();

            int StockData = 10;

            Game.Price = StockData;

            Assert.AreEqual(StockData, Game.Price);
        }

        [TestMethod]
        public void PlatformOK()
        {
            clsStock Game = new clsStock();

            string StockData = "PS4";

            Game.Platform = StockData;

            Assert.AreEqual(StockData, Game.Platform);
        }

        [TestMethod]
        public void InStockOK()
        {
            clsStock Game = new clsStock();

            Boolean StockData = true;

            Game.InStock = true;

            Assert.AreEqual(StockData, Game.InStock);
        }

        [TestMethod]
        public void StocKQuantityOK()
        {
            clsStock Game = new clsStock();

            int StockData = 5;

            Game.StockQuantity = StockData;

            Assert.AreEqual(StockData, Game.StockQuantity);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            clsStock Game = new clsStock();

            DateTime StockData = DateTime.Now.Date;

            Game.ReleaseDate = StockData;

            Assert.AreEqual(StockData, Game.ReleaseDate);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock Game = new clsStock();

            Boolean Found = false;

            Int32 StockData = 5;

            Game.productId = StockData;

            Found = Game.Find(StockData);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidOk()
        {
            clsStock Game = new clsStock();

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdExtremeMin()
        {
            clsStock Game = new clsStock();

            Int32 TestData = -500;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void productIdMinBoundary()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 1;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdMinPlusOne()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 2;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdMaxMinusOne()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 999998;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdMaxBoundary()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 999999;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdMaxPlusOne()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 1000001;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void productIdMid()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 500000;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void productIdExtremeMax()
        {
            clsStock Game = new clsStock();

            Int32 TestData = 2000000;

            productId = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleExtremeMin()
        {
            clsStock Game = new clsStock();

            String TestData = "";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMinBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "a";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "aa";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMaxMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "";
            TestData = TestData.PadRight(99, 'a');

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMaxBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "";
            TestData = TestData.PadRight(100, 'a');

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "";
            TestData = TestData.PadRight(101, 'a');

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleMid()
        {
            clsStock Game = new clsStock();

            String TestData = "";
            TestData = TestData.PadRight(50, 'a');

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameTitleExtremeMax()
        {
            clsStock Game = new clsStock();

            String TestData = "";
            TestData = TestData.PadRight(500, 'a');

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(productId, GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");

        }


    }
}
