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
            ACustomer.CustomerCardNumber = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerCardNumber, TestData);
        }

        [TestMethod]
        public void CreationDateOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            ACustomer.CustomerCreationDate = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerCreationDate, TestData);
        }

        [TestMethod]
        public void AccountStausOK()
        {
            //create an instance of the class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            Boolean TestData = true;
            //assign data to property
            ACustomer.CustomerAccountStatus = TestData;
            //test if data and property are the same
            Assert.AreEqual(ACustomer.CustomerAccountStatus, TestData);
        }

        /* --- Testing  the 'Find' method --- */

        [TestMethod]
        public void FindMethodOK()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //creat test data 
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerId
            if (ACustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerName
            if (ACustomer.CustomerName != "Joe Bloggs")
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerEmail
            if (ACustomer.CustomerEmail != "jb123@email.com")
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerPassword
            if (ACustomer.CustomerPassword != "pass123")
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerCardNumberFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerCardNumber
            if (ACustomer.CustomerCardNumber != "1234567891023456")
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerCreationDateFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerCreationDate
            if (ACustomer.CustomerCreationDate != Convert.ToDateTime("02/02/2021"))
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAccountStatusFound()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to storee the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data to use wiht the method
            ACustomer.CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(1);
            //check the CustomerAccountStatus
            if (ACustomer.CustomerAccountStatus != true)
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }
    }
}
