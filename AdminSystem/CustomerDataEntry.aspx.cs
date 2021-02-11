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

        //capture the customer id
        ACustomer.CustomerId = int.Parse(txtCustomerId.Text);
        //capture the customer name
        ACustomer.CustomerName = txtCustomerName.Text;
        //capture the customer email
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        ACustomer.CustomerPassword = txtPassword.Text;
        //capture the customer card number
        ACustomer.CardNumber = txtCardNumber.Text;
        //capture the customer creation date
        ACustomer.CardNumber = txtCardNumber.Text;
        //capture the customer account status
        ACustomer.AccountStatus = bool.Parse(chkAccountStatus.Text);

        //store the name in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}