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
    }
}
