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
        public void ThisGameOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStock TestGame = new clsStock();

            TestGame.GameTitle = "Grand Theft Auto: Vice City Stories";
            TestGame.Platform = "PSP";
            TestGame.Price = 20;
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

            TestGame.GameTitle = "Pokemon Sun";
            TestGame.Platform = "3DS";
            TestGame.Price = 12;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 21;

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

            TestGame.GameTitle = "Test Add";
            TestGame.Platform = "Playstation 1";
            TestGame.Price = 40;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 15;

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

            TestGame.GameTitle = "Test Update";
            TestGame.Platform = "Playstation 2";
            TestGame.Price = 40;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 20;

            StockCollection.ThisGame = TestGame;

            PrimaryKey = StockCollection.Add();

            TestGame.productId = PrimaryKey;

            TestGame.GameTitle = "Test Update Ok";
            TestGame.Platform = "Playstation 3";
            TestGame.Price = 45;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 25;

            StockCollection.ThisGame = TestGame;

            StockCollection.Update();

            StockCollection.ThisGame.Find(PrimaryKey);

            Assert.AreEqual(StockCollection.ThisGame, TestGame);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStock TestGame = new clsStock();

            Int32 PrimaryKey = 0;

            TestGame.GameTitle = "Ratchet & Clank";
            TestGame.Platform = "Playstation 2";
            TestGame.Price = 25;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 8;

            StockCollection.ThisGame = TestGame;

            PrimaryKey = StockCollection.Add();

            TestGame.productId = PrimaryKey;

            StockCollection.ThisGame.Find(PrimaryKey);

            StockCollection.Delete();

            Boolean Found = StockCollection.ThisGame.Find(PrimaryKey);

            Assert.IsFalse(Found);


        }

        [TestMethod]
        public void FilterByGameTitleNoneFound()
        {
            clsStockCollection FilterGameTitle = new clsStockCollection();

            FilterGameTitle.FilterByGameTitle("Superman 64");

            Assert.AreEqual(0, FilterGameTitle.Count);
        }

        [TestMethod]
        public void FilterByGameTitleFound()
        {
            clsStockCollection FilterGameTitle = new clsStockCollection();

            Boolean Ok = true;

            FilterGameTitle.FilterByGameTitle("Crash Bandicoot");

            if(FilterGameTitle.Count == 1)
            {
                if(FilterGameTitle.StockList[0].productId != 61)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilterByPriceOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStockCollection FilterPrice = new clsStockCollection();

            FilterPrice.FilterByPrice(100);

            Assert.AreEqual(StockCollection.Count, FilterPrice.Count);
        }

        [TestMethod]
        public void FilterByPriceNoneFound()
        {
            clsStockCollection FilterPrice = new clsStockCollection();

            FilterPrice.FilterByPrice(1);

            Assert.AreEqual(0, FilterPrice.Count);
        }

        [TestMethod]
        public void FilterByPriceFound()
        {
            clsStockCollection FilterPrice = new clsStockCollection();

            Boolean Ok = true;

            FilterPrice.FilterByPrice(11);

            if (FilterPrice.Count == 1)
            {
                if (FilterPrice.StockList[0].productId != 61)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilterByInStockFound()
        {
            clsStockCollection FilterInStock = new clsStockCollection();

            Boolean Ok = true;

            FilterInStock.FilterByInStock(false);

            if (FilterInStock.Count == 1)
            {
                if (FilterInStock.StockList[0].productId != 67)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilterByStockQuantityNoneFound()
        {
            clsStockCollection FilterStockQ = new clsStockCollection();

            FilterStockQ.FilterByStockQuantity(100);

            Assert.AreEqual(0, FilterStockQ.Count);
        }

        [TestMethod]
        public void FilterByStockQuantityFound()
        {
            clsStockCollection FilterStockQ = new clsStockCollection();

            Boolean Ok = true;

            FilterStockQ.FilterByStockQuantity(7);

            if (FilterStockQ.Count == 1)
            {
                if (FilterStockQ.StockList[0].productId != 71)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilterByDateOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStockCollection FilterDate = new clsStockCollection();

            FilterDate.FilterByDate(Convert.ToDateTime("01/01/2090"));

            Assert.AreEqual(StockCollection.Count, FilterDate.Count);
        }

        [TestMethod]
        public void FilterByDateNoneFound()
        {
            clsStockCollection FilterDate = new clsStockCollection();

            FilterDate.FilterByDate(Convert.ToDateTime("01/01/1980"));

            Assert.AreEqual(0, FilterDate.Count);
        }
    }
}
