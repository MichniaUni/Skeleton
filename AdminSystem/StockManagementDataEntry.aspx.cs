﻿using System;
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Itemdescription
        AnStock.ItemDescription = txtItemDescription.Text;
        //capture the RestockDate
        AnStock.RestockDate = Convert.ToDateTime(txtRestockDate.Text);
        //capture the QuantityInStock
        AnStock.QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text);
        //capture the ItemPrice
        AnStock.ItemPrice = Convert.ToDecimal(txtItemPrice.Text);
        //capture the Is Active
        AnStock.IsActive = chkIsActive.Checked;
        //store the address in the session object
        Session["AnStock"] = AnStock;              
        //navigate to the view page
        Response.Redirect("StockManagementViewer.aspx");
    }
}