using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 productId;

    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["productId"]);
    }

    protected void btnYes_Click(Object sender, EventArgs e)
    {
        clsStockCollection StockCollection = new clsStockCollection();
        StockCollection.ThisGame.Find(productId);
        StockCollection.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(Object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}