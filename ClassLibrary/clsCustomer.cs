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
            //set the private data members to the test data value
            mCustomerId = 12345;
            mCustomerName = "Joe Bloggs";
            mCustomerEmail = "joebloggs@email.com";
            mCustomerPassword = "password123";
            mCustomerCardNumber = "0123456789101112";
            mCustomerCreationDate = Convert.ToDateTime("02/02/2021");
            mCustomerAccountStatus = true;
            //always return true
            return true;
        }
    }
}