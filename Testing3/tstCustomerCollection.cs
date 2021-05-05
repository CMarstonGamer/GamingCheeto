using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //test to see if it exists
            Assert.IsNotNull(AllCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an item to  TestList
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();

            //set properties of TestItem
            TestItem.CustomerId = 7;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.CustomerEmail = "jb123@email.com";
            TestItem.CustomerPassword = "password123";
            TestItem.CustomerCardNumber = "0123456789101112";
            TestItem.CustomerCreationDate = DateTime.Now.Date;
            TestItem.CustomerAccountStatus = true;

            //add TestItem to TestList
            TestList.Add(TestItem);

            //assign TestList to AllCustomers.CustomerList
            AllCustomers.CustomerList = TestList;

            //test to see if the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create test data
            clsCustomer TestCustomer = new clsCustomer();

            //set properties of TestCustomer
            TestCustomer.CustomerId = 7;
            TestCustomer.CustomerName = "Joe Bloggs";
            TestCustomer.CustomerEmail = "jb123@email.com";
            TestCustomer.CustomerPassword = "password123";
            TestCustomer.CustomerCardNumber = "0123456789101112";
            TestCustomer.CustomerCreationDate = DateTime.Now.Date;
            TestCustomer.CustomerAccountStatus = true;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestCustomer;

            //test if they are equal
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();

            //add an item to  TestList
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();

            //set properties of TestItem
            TestItem.CustomerId = 7;
            TestItem.CustomerName = "Joe Bloggs";
            TestItem.CustomerEmail = "jb123@email.com";
            TestItem.CustomerPassword = "password123";
            TestItem.CustomerCardNumber = "0123456789101112";
            TestItem.CustomerCreationDate = DateTime.Now.Date;
            TestItem.CustomerAccountStatus = true;

            //add TestItem to TestList
            TestList.Add(TestItem);

            //assign TestList to AllCustomers.CustomerList
            AllCustomers.CustomerList = TestList;

            //test to see if the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create test data
            clsCustomer TestItem = new clsCustomer();

            //var to store primary key
            Int32 PrimaryKey = 0;

            //set properties of TestCustomer
            TestItem.CustomerId = 7;
            TestItem.CustomerName = "Seventh Person";
            TestItem.CustomerEmail = "sev7@email.com";
            TestItem.CustomerPassword = "seven777";
            TestItem.CustomerCardNumber = "3249751097492094";
            TestItem.CustomerCreationDate = DateTime.Now.Date;
            TestItem.CustomerAccountStatus = true;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see if the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create test data
            clsCustomer TestItem = new clsCustomer();

            //var to store primary key
            Int32 PrimaryKey = 0;

            //set properties of TestCustomer
            TestItem.CustomerName = "Seventh Person";
            TestItem.CustomerEmail = "sev7@email.com";
            TestItem.CustomerPassword = "seven777";
            TestItem.CustomerCardNumber = "3249751097492094";
            TestItem.CustomerCreationDate = DateTime.Now.Date;
            TestItem.CustomerAccountStatus = true;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;

            //modify the test data
            TestItem.CustomerAccountStatus = false;
            TestItem.CustomerName = "Updateguy Eightman";
            TestItem.CustomerEmail = "upd123@email.com";
            TestItem.CustomerPassword = "update1234";
            TestItem.CustomerCardNumber = "4729461083745782";
            TestItem.CustomerCreationDate = DateTime.Now.Date;

            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;

            //update the record
            AllCustomers.Update();

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of clsCustomerCollection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create test data
            clsCustomer TestItem = new clsCustomer();

            //var to store primary key
            Int32 PrimaryKey = 0;

            //set properties of TestCustomer
            TestItem.CustomerId = 7;
            TestItem.CustomerName = "Seventh Person";
            TestItem.CustomerEmail = "sev7@email.com";
            TestItem.CustomerPassword = "seven777";
            TestItem.CustomerCardNumber = "3249751097492094";
            TestItem.CustomerCreationDate = DateTime.Now.Date;
            TestItem.CustomerAccountStatus = true;

            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //delete the record
            AllCustomers.Delete();

            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see if the record was not found
            Assert.IsFalse(Found);
        }

    }
}
