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

            //assign TestCustomer to AllCustomers
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

    }
}
