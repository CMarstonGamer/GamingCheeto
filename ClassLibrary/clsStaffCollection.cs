using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff Staff = new clsStaff();
                Staff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                Staff.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
                Staff.surname = Convert.ToString(DB.DataTable.Rows[Index]["surname"]);
                Staff.managerOrStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["managerOrStaff"]);
                Staff.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOfBirth"]);
                Staff.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                mStaffList.Add(Staff);
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //blank for now
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@staffId", mThisStaff.staffId);
            DB.AddParameter("@surname", mThisStaff.surname);
            DB.AddParameter("@firstName", mThisStaff.firstName);
            DB.AddParameter("@dateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@managerOrStaff", mThisStaff.managerOrStaff);
            DB.AddParameter("@password", mThisStaff.password);
           
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", mThisStaff.staffId);
            DB.AddParameter("@firstName", mThisStaff.firstName);
            DB.AddParameter("@surname", mThisStaff.surname);
            DB.AddParameter("@managerOrStaff", mThisStaff.managerOrStaff);
            DB.AddParameter("@dateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@password", mThisStaff.password);
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}