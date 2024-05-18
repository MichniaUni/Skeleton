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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Itemdescription
        string ItemDescription = txtItemDescription.Text;
        //capture the RestockDate
        string RestockDate = txtRestockDate.Text;
        //capture the QuantityInStock
        string QuantityInStock = txtQuantityInStock.Text;
        //capture the ItemPrice
        string ItemPrice = txtItemPrice.Text;
        //capture the Is Active
        string IsActive = chkIsActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStock.Valid(ItemDescription, RestockDate, QuantityInStock, ItemPrice);
        if(Error == "")
        {
            //capture the Itemdescription
            AnStock.ItemDescription = ItemDescription;
            //capture the RestockDate
            AnStock.RestockDate = Convert.ToDateTime(RestockDate);
            //capture the QuantityInStock
            AnStock.QuantityInStock = Convert.ToInt32(QuantityInStock);
            //capture the ItemPrice
            AnStock.ItemPrice = Convert.ToDecimal(ItemPrice);
            //store the address in the session object
            Session["AnStock"] = AnStock;
            //navigate to the view page
            Response.Redirect("StockManagementViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}