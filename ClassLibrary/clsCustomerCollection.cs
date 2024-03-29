﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //to do later
            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAddress
            
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerCardNumber", mThisCustomer.CustomerCardNumber);
            DB.AddParameter("@CustomerCreationDate", mThisCustomer.CustomerCreationDate);
            DB.AddParameter("@CustomerAccountStatus", mThisCustomer.CustomerAccountStatus);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer

            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerCardNumber", mThisCustomer.CustomerCardNumber);
            DB.AddParameter("@CustomerCreationDate", mThisCustomer.CustomerCreationDate);
            DB.AddParameter("@CustomerAccountStatus", mThisCustomer.CustomerAccountStatus);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by the database

            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the store procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            //filters the records based on a full or partial customer name

            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //send the CustomerName parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");

            //poulate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //poulates the array list based on the data table in the parameter DB

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            
            //get the count of the records
            RecordCount = DB.Count;

            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            //while there are no records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();

                //read in the fields from the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.CustomerCardNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerCardNumber"]);
                ACustomer.CustomerCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerCreationDate"]);
                ACustomer.CustomerAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerAccountStatus"]);

                //add the record to the private member
                mCustomerList.Add(ACustomer);

                //point at the next record
                Index++;
            }
        }
    }
}