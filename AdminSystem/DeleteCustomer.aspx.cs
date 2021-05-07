using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var to store the primary key value of the record too be deleted
    Int32 CustomerId;

    //event handler fpr the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of the customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance clsCustomerCollection
        clsCustomerCollection AllCustomers = new clsCustomerCollection();

        //find the record to delete
        AllCustomers.ThisCustomer.Find(CustomerId);

        //delete the record
        AllCustomers.Delete();

        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}