using System;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        public int staffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        private string mFirstName;
        public string firstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        private string mSurname;
        public string surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }
        private bool mManagerOrStaff;
        public bool managerOrStaff
        {
            get
            {
                return mManagerOrStaff;
            }
            set
            {
                mManagerOrStaff = value;
            }
        }
        private DateTime mDateOfBirth;
        public DateTime dateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        private string mPassword;
        public string password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public bool Find(int staffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", staffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mManagerOrStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["ManagerOrStaff"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }

            else
            {
                return false;
            }
           
        }

        public string Valid(string firstName, string surname, string managerOrStaff, string dateOfBirth, string password)
        {
            String Error = "";
            if (firstName.Length == 0)
            {
                Error = Error + "The firstName must not be blank : ";

            }
            return Error;
        }
    }
}