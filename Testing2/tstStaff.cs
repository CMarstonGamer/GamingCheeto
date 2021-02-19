using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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

    }
}
