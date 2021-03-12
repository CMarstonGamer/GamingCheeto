using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to the method
        string CustomerId = "1";
        string CustomerName = "Joe Bloggs";
        string CustomerEmail = "joebloggs123@email.com";
        string CustomerPassword = "password123";
        string CustomerCardNumber = "0123456789101112";
        string CustomerCreationDate = DateTime.Now.Date.ToString();

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

        /* --- 
         * 
         * Testing  the 'Find' method 
         * 
         * --- */

        [TestMethod]
        public void FindMethodOK()
        {
            //creat an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //creat test data 
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 2;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the CustomerName
            if (ACustomer.CustomerName != "Jack Blaggs")
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
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
            Int32 CustomerId = 1;
            ACustomer.CustomerId = CustomerId;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the CustomerAccountStatus
            if (ACustomer.CustomerAccountStatus != true)
            {
                OK = false;
            }
            //test to see that the redult is correct
            Assert.IsTrue(OK);
        }

        /* --- 
         * 
         * Testing  the 'Valid' method
         * 
         * --- */

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //uses AreNotEqual to verify an unwanted value
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "1";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "12";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "1";
            CustomerId.PadRight(9999, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "1";
            CustomerId.PadRight(10000, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "10001"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //uses AreNotEqual to verify an unwanted value
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerId = "50000"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //uses AreNotEqual to verify an unwanted value
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //uses AreNotEqual to verify an unwanted value
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "Ab"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A";
            CustomerName = CustomerName.PadRight(99, 'a');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A";
            CustomerName = CustomerName.PadRight(100, 'a');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A";
            CustomerName = CustomerName.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A";
            CustomerName = CustomerName.PadRight(101, 'a');//this trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "A";
            CustomerName = CustomerName.PadRight(1000, 'a');//this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "j";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "jo";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "joebloggs@emai.com";
            CustomerEmail = CustomerEmail.PadLeft(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "joebloggs@emai.com";
            CustomerEmail = CustomerEmail.PadLeft(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "joebloggs@emai.com";
            CustomerEmail = CustomerEmail.PadLeft(51, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "joebloggs@emai.com";
            CustomerEmail = CustomerEmail.PadLeft(500, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "pass"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "passw";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "passwo";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "password123";
            CustomerPassword = CustomerPassword.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "password123";
            CustomerPassword = CustomerPassword.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "password123";
            CustomerPassword = CustomerPassword.PadRight(51, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "password123";
            CustomerPassword = CustomerPassword.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerPassword = "password123";
            CustomerPassword = CustomerPassword.PadRight(500, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardNumberMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerCardNumber = "123456789101234"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardNumberMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerCardNumber = "1234567891012345";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardNumberMaxPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerCardNumber = "12345678910123456"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCardNumberExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerCardNumber = "12345678910123456";
            CustomerCardNumber = CustomerCardNumber.PadRight(500, '1'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateExtremeMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to minus 100 years
            TestDate = TestDate.AddYears(-100); //this should trigger an error
            //convert the date to variable to string variable
            string CustomerCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateMinLessOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to minus 1 day
            TestDate = TestDate.AddDays(-1); //this should trigger an error
            //convert the date to variable to string variable
            string CustomerCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateMin()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to variable to string variable
            string CustomerCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateMinPlusOne()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to plus 1 day
            TestDate = TestDate.AddDays(1); //this should trigger an error
            //convert the date to variable to string variable
            string CustomerCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateExtremeMax()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to plus 100 years
            TestDate = TestDate.AddYears(100); //this should trigger an error
            //convert the date to variable to string variable
            string CustomerCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerCreationDateInvalidData()
        {
            //create instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerCreationDate = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerId, CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
