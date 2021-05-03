using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        string CustomerPassword = txtCustomerPassword.Text;
        //capture the customer card number
        string CustomerCardNumber = txtCustomerCardNumber.Text;
        //capture the customer creation date
        string CustomerCreationDate = txtCustomerCardNumber.Text;
        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, CustomerCardNumber, CustomerCreationDate);
        if (Error == "")
        {
            
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer password
            ACustomer.CustomerPassword = CustomerPassword;
            //capture the customer card number
            ACustomer.CustomerCardNumber = CustomerCardNumber;
            //capture the customer creation date
            ACustomer.CustomerCreationDate = Convert.ToDateTime(CustomerCreationDate);

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;

            //add the new record
            CustomerList.Add();

            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        ACustomer.CustomerId = CustomerId; //applied CustomerId to ACustomer to fix the issue
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = ACustomer.CustomerId.ToString();
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPassword.Text = ACustomer.CustomerPassword;
            txtCustomerCardNumber.Text = ACustomer.CustomerCardNumber;
            txtCustomerCreationDate.Text = ACustomer.CustomerCreationDate.ToString();
        }
        else
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerPassword.Text = "";
            txtCustomerCardNumber.Text = "";
            txtCustomerCreationDate.Text = "";
        }
    }
}