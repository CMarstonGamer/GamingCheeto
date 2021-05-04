using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create instance of clsCustomerCollection
        clsCustomerCollection AllCustomers = new clsCustomerCollection();

        //set the data source to the list of customers in the collections
        lstCustomerList.DataSource = AllCustomers.CustomerList;

        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";

        //set the data field to display
        lstCustomerList.DataTextField = "CustomerName";

        //bind the data to the list
        lstCustomerList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;

        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerId;

        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);

            //store the data in the session object
            Session["CustomerId"] = CustomerId;

            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}