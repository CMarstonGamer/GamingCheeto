using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            int TestData = 12345;
            //assign data to property
            ACustomer.CustomerId = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            string TestData = "Joe Bloggs";
            //assign data to property
            ACustomer.CustomerName = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            string TestData = "jbloggs@email.com";
            //assign data to property
            ACustomer.CustomerEmail = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPasswordOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            string TestData = "password123";
            //assign data to property
            ACustomer.CustomerPassword = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CardNumberOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            string TestData = "0123456789101112";
            //assign data to property
            ACustomer.CardNumber = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CardNumber, TestData);
        }

        [TestMethod]
        public void CreationDateOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            ACustomer.CreationDate = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CreationDate, TestData);
        }

        [TestMethod]
        public void AccountStausOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            Boolean TestData = true;
            //assign data to property
            ACustomer.AccountStatus = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.AccountStatus, TestData);
        }
    }
}
