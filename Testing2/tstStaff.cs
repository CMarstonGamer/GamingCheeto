using System;
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
            if (AStaff.dateOfBirth != Convert.ToDateTime("18/03/2021"))

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
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
            Assert.AreEqual(Error, "");
        }
       [TestMethod]
       public void firstNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String firstName = "";
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMin()
        {
           
            clsStaff AStaff = new clsStaff();
            
            String Error = "";
            
            string firstName = "a"; 
            
            Error = AStaff.Valid(firstName, surname, dateOfBirth,password);
            
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void firstNameMinPlusOne()
        {
            
            clsStaff AStaff = new clsStaff();
          
            String Error = "";
           
            string firstName = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
            
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void firstNameMaxLessOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string firstName = "aaaaa"; 
            
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void firstNameMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string firstName = "aaaaaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void firstNameMaxPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string firstName = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void firstNameMid()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string firstName = "aaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void firstNameExtremeMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string firstName = "";
            firstName = firstName.PadRight(500, 'a');


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void surnameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String surname = "";
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void surnameMin()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "a";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void surnameMinPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void surnameMaxLessOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "aaaaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void surnameMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "aaaaaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void surnameMaxPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void surnameMid()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "aaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void surnameExtremeMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string surname = "";
            surname = surname.PadRight(500, 'a');


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void passwordMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String password = "";
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void passwordMin()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "a";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void passwordMinPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void passwordMaxLessOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "aaaaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void passwordMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "aaaaaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void passwordMaxPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void passwordMid()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "aaa";

            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void passwordExtremeMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            string password = "";
            password = password.PadRight(500, 'a');


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void dateOfBirthMinLessOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String dateOfBirth = TestDate.ToString();


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void dateOfBirthMin()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
          
            String dateOfBirth = TestDate.ToString();


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void dateOfBirthMinPlusOne()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String dateOfBirth = TestDate.ToString();


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void dateOfBirthMinExtremeMin()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String dateOfBirth = TestDate.ToString();


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void dateOfBirthMinExtremeMax()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String dateOfBirth = TestDate.ToString();


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void dateOfBirthMinInvalidData()
        {

            clsStaff AStaff = new clsStaff();

            String Error = "";

           
            String dateOfBirth = "this is not a date";


            Error = AStaff.Valid(firstName, surname, dateOfBirth, password);

            Assert.AreNotEqual(Error, "");

        }
    }
}
