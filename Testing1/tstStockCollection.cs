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
            //create instance of clsCustomerCollection
            clsStockCollection StockCollection = new clsStockCollection();

            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();

            //add an item to  TestList
            //create the item of the test data
            clsStock TestItem = new clsStock();

            //set properties of TestItem
            TestItem.productId = 1;
            TestItem.GameTitle = "Devil May Cry";
            TestItem.Platform = "Playstation 4";
            TestItem.Price = 12;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.InStock = true;

            //add TestItem to TestList
            TestList.Add(TestItem);

            //assign TestList to AllCustomers.CustomerList
            StockCollection.StockList = TestList;

            //test to see if the two values are the same
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

            TestGame.productId = 1;
            TestGame.GameTitle = "Devil May Cry";
            TestGame.Platform = "Playstation 4";
            TestGame.Price = 12;
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.InStock = true;

            StockCollection.ThisGame = TestGame;

            Assert.AreEqual(StockCollection.ThisGame, TestGame);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsStockCollection StockCollection = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.productId = 1;
            TestItem.GameTitle = "Devil May Cry";
            TestItem.Platform = "Playstation 4";
            TestItem.Price = 12;
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.InStock = true;

            TestList.Add(TestItem);

            StockCollection.StockList = TestList;

            Assert.AreEqual(StockCollection.Count, TestList.Count);
        }
    }
}
