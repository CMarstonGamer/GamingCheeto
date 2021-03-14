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
            clsStaff DB = new clsStaff();
            //DB.AddParameter("@staffId", staffId);
            mStaffId = 21;
            mFirstName = "Chris";
            mSurname = "Marston";
            mManagerOrStaff = true;
            mDateOfBirth = DateTime.Now.Date;
            mPassword = "bruhhhh";
            return true;
        }
    }
}