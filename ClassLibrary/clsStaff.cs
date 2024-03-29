﻿using System;
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

        public string Valid(string firstName, string surname, string dateOfBirth, string password)
        {
            String Error = "";
            DateTime DateTemp;

            if (firstName.Length == 0)
            {
                Error = Error + "The firstName must not be blank : ";

            }
            if (firstName.Length > 50)
            {
                Error = Error + "The first name must be less than 50 characters: ";
            }
            if (surname.Length == 0)
            {
                Error = Error + "The surname must not be blank : "; 
            }
            if (surname.Length > 50)
            {
                Error = Error + "The surname must be less than 50 characters: ";
            }
            if (password.Length == 0)
            {
                Error = Error + "The password must not be blank : ";
            }
            if (password.Length > 50)
            {
                Error = Error + "The password must be less than 50 characters: ";
            }
           
            try

            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Today.AddYears(100))
                {
                    Error = Error + "Date of Birth can't be 100 years in the future: ";
                }
                if (DateTemp <= DateTime.Now.Date.AddDays(-1))
                {
                    Error = Error + "Date of Birth can't be yesterday: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Date of Birth can't be in the future: ";
                }
                if (DateTemp > DateTime.Today.AddDays(1))
                {
                    Error = Error + "Date of Birth can't be in the future by 1 day: ";
                }
                if (DateTemp <= DateTime.Today.AddYears(-100))
                {
                    Error = Error + "Date of Birth can't be in the past by more than 100 years: ";
                }
            }
            catch
            {
                Error = Error + "the date of birth was not a valid date";
            }
            return Error;
        }
    }
}