﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from yhe session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display supplier ID
        Response.Write(AnSupplier.SupplierID);
        //display Supplier name
        Response.Write(AnSupplier.SupplierName);
        //display Production Date
        Response.Write(AnSupplier.ProductionDate);
        //display ExpiryDate
        Response.Write(AnSupplier.ExpiryDate);
        //display Quantity
        Response.Write(AnSupplier.Quantity);
        //display price
        Response.Write(AnSupplier.Price);


    }
    

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierManagementConfirmDelete.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }
}