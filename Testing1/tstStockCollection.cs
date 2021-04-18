using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsStockCollection StockCollection = new clsStockCollection();

            Assert.IsNotNull(StockCollection);
        }

        [TestMethod]
        public void StockListOK()
        {
            
            clsStockCollection StockCollection = new clsStockCollection();


            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.GameTitle = "Devil May Cry";
            TestItem.Platform = "Playstation 4";
            TestItem.Price = 12;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.InStock = true;
            TestItem.StockQuantity = 2;

            TestList.Add(TestItem);

            StockCollection.StockList = TestList;

            Assert.AreEqual(StockCollection.StockList, TestList);
        }

        [TestMethod]
        public void CountStockOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            Int32 SomeCount = 0;

            StockCollection.Count = SomeCount;

            Assert.AreEqual(StockCollection.Count, SomeCount);
        }

        [TestMethod]
        public void ThisGameOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStock TestGame = new clsStock();

            TestGame.GameTitle = "Devil May Cry";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 12;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 2;

            StockCollection.ThisGame = TestGame;

            Assert.AreEqual(StockCollection.ThisGame, TestGame);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestGame = new clsStock();

            TestGame.GameTitle = "Devil May Cry";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 12;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = false;
            TestGame.StockQuantity = 2;

            TestList.Add(TestGame);

            StockCollection.StockList = TestList;

            Assert.AreEqual(StockCollection.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStock TestGame = new clsStock();

            Int32 PrimaryKey = 0;

            TestGame.GameTitle = "Devil May Cry";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 12;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 2;

            StockCollection.ThisGame = TestGame;

            PrimaryKey = StockCollection.Add();

            TestGame.productId = PrimaryKey;

            StockCollection.ThisGame.Find(PrimaryKey);

            Assert.AreEqual(StockCollection.ThisGame, TestGame);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStock TestGame = new clsStock();

            Int32 PrimaryKey = 0;

            TestGame.GameTitle = "Bloodborne";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 40;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 4;

            StockCollection.ThisGame = TestGame;

            PrimaryKey = StockCollection.Add();

            TestGame.productId = PrimaryKey;

            TestGame.GameTitle = "Bloodborne";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 25;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 8;

            StockCollection.ThisGame = TestGame;

            StockCollection.Update();

            StockCollection.ThisGame.Find(PrimaryKey);

            Assert.AreEqual(StockCollection.ThisGame, TestGame);
        }
    }
}
