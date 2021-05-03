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

        Response.Redirect("StockDataEntry.aspx");
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

    protected void btnApply_Click(Object sender, EventArgs e)
    {
        clsStockCollection StockCollection = new clsStockCollection();

        StockCollection.FilterByGameTitle(txtGameTitle.Text);

        lstStockCollection.DataSource = StockCollection.StockList;

        lstStockCollection.DataValueField = "productId";

        lstStockCollection.DataTextField = "GameTitle";

        lstStockCollection.DataBind();
    }

    protected void btnClear_Click(Object sender, EventArgs e)
    {
        clsStockCollection StockCollection = new clsStockCollection();

        StockCollection.FilterByGameTitle("");

        txtGameTitle.Text = "";

        lstStockCollection.DataSource = StockCollection.StockList;

        lstStockCollection.DataValueField = "productId";

        lstStockCollection.DataTextField = "GameTitle";

        lstStockCollection.DataBind();
    }

    protected void btnApplyPrice_Click(Object sender, EventArgs e)
    {
        try
        {
            Int32 FilteredPrice = Convert.ToInt32(txtPrice.Text);

            clsStockCollection StockCollection = new clsStockCollection();

            StockCollection.FilterByPrice(FilteredPrice);

            lstStockCollection.DataSource = StockCollection.StockList;

            lstStockCollection.DataValueField = "productId";

            lstStockCollection.DataTextField = "GameTitle";

            lstStockCollection.DataBind();
        }
        catch
        {
            lblError.Text = "Please enter a Number";
        }

    }


    protected void btnApplyInStock_Click(object sender, EventArgs e)
    {
        Boolean mInStock = chkInStock.Checked;

        clsStockCollection StockCollection = new clsStockCollection();

        StockCollection.FilterByInStock(mInStock);

        lstStockCollection.DataSource = StockCollection.StockList;

        lstStockCollection.DataValueField = "productId";

        lstStockCollection.DataTextField = "GameTitle";

        lstStockCollection.DataBind();
    }

    protected void btnApplyStockQ_Click(object sender, EventArgs e)
    {
        try
        {
            int mStockQ = Convert.ToInt32(txtStockQuantity.Text);

            clsStockCollection StockCollection = new clsStockCollection();

            StockCollection.FilterByStockQuantity(mStockQ);

            lstStockCollection.DataSource = StockCollection.StockList;

            lstStockCollection.DataValueField = "productId";

            lstStockCollection.DataTextField = "GameTitle";

            lstStockCollection.DataBind();
        }
        catch
        {
            lblError.Text = "Please Enter a Number";
        }
    }

    protected void btnApplyDate_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

            clsStockCollection StockCollection = new clsStockCollection();

            StockCollection.FilterByDate(ReleaseDate);

            lstStockCollection.DataSource = StockCollection.StockList;

            lstStockCollection.DataValueField = "productId";

            lstStockCollection.DataTextField = "GameTitle";

            lstStockCollection.DataBind();
        }
        catch
        {
            lblError.Text = "Please enter a date";
        }
    }
}