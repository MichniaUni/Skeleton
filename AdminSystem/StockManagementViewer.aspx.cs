using System;
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
        //create a new instance of clcStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //display the Item Description for this entry
        Response.Write(AnStock.ItemDescription);
        Response.Write(AnStock.RestockDate);
        Response.Write(AnStock.QuantityInStock);
        Response.Write(AnStock.ItemPrice);
        Response.Write(AnStock.IsActive);
    }
}