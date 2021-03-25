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
}