﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.managerOrStaff = true;
            TestItem.firstName = "Chris";
            TestItem.surname = "Marston";
            TestItem.dateOfBirth = DateTime.Now.Date;
            TestItem.password = "bruh";
            TestItem.staffId = 1;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
       // [TestMethod]
       // public void CountPropertyOK()
        //{
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    Int32 SomeCount = 2;
        //    AllStaff.Count = SomeCount;
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.managerOrStaff = true;
            TestStaff.firstName = "Chris";
            TestStaff.surname = "Marston";
            TestStaff.dateOfBirth = DateTime.Now.Date;
            TestStaff.password = "bruh";
            TestStaff.staffId = 1;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.staffId = 1;
            TestItem.firstName = "chris";
            TestItem.surname = "Marston";
            TestItem.managerOrStaff = true;
            TestItem.dateOfBirth = DateTime.Now.Date;
            TestItem.password = "bruh";
            TestList.Add(TestItem);
            allStaff.StaffList = TestList;
            Assert.AreEqual(allStaff.Count, TestList.Count);

        }
        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    Assert.AreEqual(AllStaff.Count, 2);
        //}
    }
}