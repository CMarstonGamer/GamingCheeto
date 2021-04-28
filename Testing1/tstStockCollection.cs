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

            TestGame.GameTitle = "Crash Bandicoot";
            TestGame.Platform = "Playstation 1";
            TestGame.Price = 10;
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

            TestGame.GameTitle = "Assassins Creed: Black Flag";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 40;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 4;

            StockCollection.ThisGame = TestGame;

            PrimaryKey = StockCollection.Add();

            TestGame.productId = PrimaryKey;

            TestGame.GameTitle = "Assassins Creed Unity";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 20;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;
            TestGame.StockQuantity = 8;

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
        public void FilterByGameTitleOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            clsStockCollection FilterGameTitle = new clsStockCollection();

            FilterGameTitle.FilterByGameTitle ("");

            Assert.AreEqual(StockCollection.Count, FilterGameTitle.Count);
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

            FilterPrice.FilterByPrice(0);

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
    }
}
