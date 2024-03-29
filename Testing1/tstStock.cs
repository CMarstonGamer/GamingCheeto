﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        string productId = "1";
        string GameTitle = "Devil May Cry";
        string Price = "12";
        string Platform = "Playstation 4";
        string StockQuantity = "2";
        string InStock = "true";
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

            Int32 StockData = 61;

            Game.productId = StockData;

            Found = Game.Find(StockData);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidOk()
        {
            clsStock Game = new clsStock();

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void GameTitleExtremeMin()
        {
            clsStock Game = new clsStock();

            String TestData = "";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "a";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "aa";

            GameTitle = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

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

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

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

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

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

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

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

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

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

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock Game = new clsStock();

            String TestData = "-100";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "0";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "1";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "2";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "999";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "1000";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "1001";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock Game = new clsStock();

            String TestData = "500";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock Game = new clsStock();

            String TestData = "5000";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidDataType()
        {
            clsStock Game = new clsStock();

            String TestData = "Hello";

            Price = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMin()
        {
            clsStock Game = new clsStock();

            String TestData = "-500";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "-1";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "0";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "1";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "999";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "1000";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "1001";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            clsStock Game = new clsStock();

            String TestData = "500";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMax()
        {
            clsStock Game = new clsStock();

            String TestData = "5000";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityInvalidData()
        {
            clsStock Game = new clsStock();

            String TestData = "Hello";

            StockQuantity = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsStock Game = new clsStock();

            String TestData = "01/01/1900";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinMinusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "31/12/1969";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinBoundary()
        {
            clsStock Game = new clsStock();

            String TestData = "01/01/1970";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsStock Game = new clsStock();

            String TestData = "02/01/1970";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxMinusOne()
        {
            clsStock Game = new clsStock();

            DateTime TestData = (DateTime.Now.Date).AddDays(-1);

            ReleaseDate = Convert.ToString(TestData);

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxBoundary()
        {
            clsStock Game = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            ReleaseDate = Convert.ToString(TestData);

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMaxPlusOne()
        {
            clsStock Game = new clsStock();

            DateTime TestData = (DateTime.Now.Date).AddDays(1);

            ReleaseDate = Convert.ToString(TestData);

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMid()
        {
            clsStock Game = new clsStock();

            String TestData = "12/12/2000";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsStock Game = new clsStock();

            String TestData = "01/01/3020";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsStock Game = new clsStock();

            String TestData = "Hello";

            ReleaseDate = TestData;

            String Error = "";

            Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

            Assert.AreNotEqual(Error, "");
        }
    }
}
