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
}