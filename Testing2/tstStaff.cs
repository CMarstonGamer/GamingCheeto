﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        string firstName = "Chris";
        string surname = "Marston";
        string managerOrStaff = "true";
        string dateOfBirth = DateTime.Now.Date.ToString();
        string password = "bruh";
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff anStaff = new clsStaff();
            Assert.IsNotNull(anStaff);
        }
        [TestMethod]
        public void managerOrStaffPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.managerOrStaff = TestData;
            Assert.AreEqual(AStaff.managerOrStaff, TestData);
        }
        [TestMethod]
        public void staffIdPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 1;
            AStaff.staffId = TestData;
            Assert.AreEqual(AStaff.staffId, TestData);
        }
        [TestMethod]
        public void firstNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Chris";
            AStaff.firstName = TestData;
            Assert.AreEqual(AStaff.firstName, TestData);
        }
        [TestMethod]
        public void surnamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Marston";
            AStaff.surname = TestData;
            Assert.AreEqual(AStaff.surname, TestData);
        }
        [TestMethod]
        public void passwordPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "bruh";
            AStaff.password = TestData;
            Assert.AreEqual(AStaff.password, TestData);
        }
        [TestMethod]
        public void dateOfBirthPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.dateOfBirth = TestData;
            Assert.AreEqual(AStaff.dateOfBirth, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.staffId != 6)
            { 
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.firstName != "Chris")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurnameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.surname != "Marston")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestManagerOrStaffFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.managerOrStaff != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.dateOfBirth != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 6;
            Found = AStaff.Find(staffId);
            if (AStaff.password != "bruhhhh")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(firstName, surname, managerOrStaff, dateOfBirth, password);
            Assert.AreEqual(Error, "");
        }
       [TestMethod]
       public void firstNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String firstName = "";
            Error = AStaff.Valid(firstName, surname, managerOrStaff, dateOfBirth, password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string firstName = "a"; //this should be ok
            //invoke the method
            Error = AnAddress.Valid(firstName, surname, managerOrStaff, dateOfBirth,password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string firstName = "a"; //this should be ok
            //invoke the method
            Error = AnAddress.Valid(firstName, surname, managerOrStaff, dateOfBirth, password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
