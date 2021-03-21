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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock Game = new clsStock;

        Game.GameTitle = txtGameTitle.Text;

        Game.Price = Convert.ToInt32(txtPrice.Text);

        Game.Platform = drpPlatform.Text;

        Game.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);

        Game.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);

        Session["Game"] = Game;

        Response.Write("StockViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Game = new clsStock();

        Int32 ProductId;

        Boolean Found = false;

        ProductId = Convert.ToInt32(txtProductId);

        Game.productId = ProductId;

        Found = Game.Find(ProductId);

        if (Found == true)
        {
            txtProductId.Text = Game.productId.ToString();
            txtGameTitle.Text = Game.GameTitle;
            txtPrice.Text = Game.Price.ToString();
            drpPlatform.Text = Game.Platform;
            txtReleaseDate.Text = Game.ReleaseDate.ToString();
            txtStockQuantity.Text = Game.StockQuantity.ToString();


        }
    }
}