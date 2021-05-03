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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);

           // Int32 Index = 0;
            //Int32 RecordCount = 0;
           // clsDataConnection DB = new clsDataConnection();
          //  DB.Execute("sproc_tblStaff_SelectAll");
           // RecordCount = DB.Count;
           // while (Index < RecordCount)
           // {
            //    clsStaff Staff = new clsStaff();
              //  Staff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
             //   Staff.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
              //  Staff.surname = Convert.ToString(DB.DataTable.Rows[Index]["surname"]);
             //   Staff.managerOrStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["managerOrStaff"]);
              //  Staff.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOfBirth"]);
               // Staff.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
              //  mStaffList.Add(Staff);
              //  Index++;
            //}
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
            DB.AddParameter("@Surname", mThisStaff.surname);
            DB.AddParameter("@Firstname", mThisStaff.firstName);
            DB.AddParameter("@DateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@ManagerOrStaff", mThisStaff.managerOrStaff);
            DB.AddParameter("@Password", mThisStaff.password);
           
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.staffId);
            DB.AddParameter("@Firstname", mThisStaff.firstName);
            DB.AddParameter("@Surname", mThisStaff.surname);
            DB.AddParameter("@ManagerOrStaff", mThisStaff.managerOrStaff);
            DB.AddParameter("@DateOfBirth", mThisStaff.dateOfBirth);
            DB.AddParameter("@Password", mThisStaff.password);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.staffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFirstName(string firstNameFilter)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@firstName", firstNameFilter);
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff aStaff = new clsStaff();
                aStaff.staffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                aStaff.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
                aStaff.surname = Convert.ToString(DB.DataTable.Rows[Index]["surname"]);
                aStaff.managerOrStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["managerOrStaff"]);
                aStaff.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOfBirth"]);
                aStaff.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                mStaffList.Add(aStaff);
                Index++;
            }
        }
    }
}