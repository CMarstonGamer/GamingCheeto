﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 productId;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["productId"]);
        if(IsPostBack == false)
        {
            if(productId != -1)
            {
                DisplayGame();
            }
        }
    }

    protected void chkInStock_Click(object sender, EventArgs e)
    {
            txtStockQuantity.Enabled = true;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock Game = new clsStock();

        string GameTitle = txtGameTitle.Text;
        string Price = txtPrice.Text;
        string Platform = drpPlatform.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string StockQuantity = txtStockQuantity.Text;
        Boolean InStock = chkInStock.Checked;
        string Error = "";

        Error = Game.Valid(GameTitle, Price, Platform, StockQuantity, ReleaseDate);

        if (Error == "")
        {
            Game.productId = productId;
            Game.GameTitle = GameTitle;
            Game.Price = Convert.ToInt32(Price);
            Game.Platform = Platform;
            Game.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            Game.StockQuantity = Convert.ToInt32(StockQuantity);
            Game.InStock = InStock;

            clsStockCollection StockCollection = new clsStockCollection();       

            if (productId == -1)
            {
                StockCollection.ThisGame = Game;
                StockCollection.Add();
                Response.Redirect("StockList.aspx");
            }
            else
            {
                StockCollection.ThisGame.Find(productId);
                StockCollection.ThisGame = Game;
                StockCollection.Update();
                Response.Redirect("StockList.aspx");
            }
            
        }

        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Game = new clsStock();

        Int32 productId;

        Boolean Found = false;

        productId = Convert.ToInt32(txtProductId.Text);

        Game.productId = productId;

        Found = Game.Find(productId);

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

    void DisplayGame()
    {
        clsStockCollection StockCollection = new clsStockCollection();

        StockCollection.ThisGame.Find(productId);

        txtProductId.Text = StockCollection.ThisGame.productId.ToString();
        txtGameTitle.Text = StockCollection.ThisGame.GameTitle;
        txtPrice.Text = StockCollection.ThisGame.Price.ToString();
        drpPlatform.Text = StockCollection.ThisGame.Platform;
        txtReleaseDate.Text = StockCollection.ThisGame.ReleaseDate.ToString();
        txtStockQuantity.Text = StockCollection.ThisGame.StockQuantity.ToString();
        chkInStock.Checked = StockCollection.ThisGame.InStock;
        

    }
                
}