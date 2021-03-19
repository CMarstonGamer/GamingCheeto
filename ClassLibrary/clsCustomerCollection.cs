using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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
                //
            }
        }

        public clsCustomer ThisCustomer { get; set; }

        //constructor
        public clsCustomerCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;

            //object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //get the count of record
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
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