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
        Session["ProductId"] = -1;

        Response.Redirect("StockDataEntry.apsx");
    }

    protected void btnEdit_Click(Object sender, EventArgs e)
    {
        Int32 ProductId;

        if(lstStockCollection.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstStockCollection.SelectedValue);

            Session["ProductId"] = ProductId;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to Edit from the list";
        }
    }
}