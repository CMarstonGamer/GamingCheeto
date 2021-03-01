using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //CustomerId private member variable
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        //CustomerName private member variable
        private string mCustomerName;
        //CustomerName public property
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }

        //CustomerEmail private member variable
        private string mCustomerEmail;
        //CustomerEmail public property
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        //CustomerPassword private member variable
        private string mCustomerPassword;
        //CustomerPassword public property
        public string CustomerPassword
        {
            get
            {
                return mCustomerPassword;
            }
            set
            {
                mCustomerPassword = value;
            }
        }

        //CustomerCardNumber private member variable
        private string mCustomerCardNumber;
        //CustomerCardNumber public property
        public string CustomerCardNumber
        {
            get
            {
                return mCustomerCardNumber;
            }
            set
            {
                mCustomerCardNumber = value;
            }
        }

        //CustomerCreationDate private member variable
        private DateTime mCustomerCreationDate;
        //CustomerCreationDate public property
        public DateTime CustomerCreationDate
        {
            get
            {
                return mCustomerCreationDate;
            }
            set
            {
                mCustomerCreationDate = value;
            }
        }

        //CustomerAccountStatus private member variable
        private Boolean mCustomerAccountStatus;
        //CustomerAccountStatus public property
        public bool CustomerAccountStatus
        {
            get
            {
                return mCustomerAccountStatus;
            }
            set
            {
                mCustomerAccountStatus = value;
            }
        }


        public bool Find(int customerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerId to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerCardNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerCardNumber"]);
                mCustomerCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerCreationDate"]);
                mCustomerAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerAccountStatus"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

    }
}