using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection StockCollection = new clsStockCollection();

        lstStockCollection.DataSource = StockCollection.StockList;

        lstStockCollection.DataValueField = "productId";

        lstStockCollection.DataTextField = "GameTitle";

        lstStockCollection.DataBind();
    }

    protected void btnAdd_Click(Object sender, EventArgs e)
    {
        Session["productId"] = -1;

        Response.Redirect("StockDataEntry.apsx");
    }

    protected void btnEdit_Click(Object sender, EventArgs e)
    {
        Int32 productId;

        if(lstStockCollection.SelectedIndex != -1)
        {
            productId = Convert.ToInt32(lstStockCollection.SelectedValue);

            Session["productId"] = productId;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit from the list";
        }
    }

    protected void btnDelete_Click(Object sender, EventArgs e)
    {
        Int32 productId;

        if(lstStockCollection.SelectedIndex != -1)
        {
            productId = Convert.ToInt32(lstStockCollection.SelectedValue);

            Session["productId"] = productId;

            Response.Redirect("StockConfirmDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }
}