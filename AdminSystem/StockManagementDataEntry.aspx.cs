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
            //capture the IsActive
            AnStock.IsActive = chkIsActive.Checked;
            //create a new instance of the address collection
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisItem property
            StockList.ThisItem = AnStock;
            //add the new record
            StockList.Add();
            //redirect back to the list page
            Response.Redirect("StockManagementList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock AnStock = new clsStock();
        //creat a variable to store the primary key
        Int32 ItemId;
        //create a variable to store the result of find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ItemId = Convert.ToInt32(txtItemId.Text);
        //find the record
        Found = AnStock.Find(ItemId);
        //if found
        if(Found == true)
        {
            //display the values of the propertise in the form
            txtItemDescription.Text = AnStock.ItemDescription;
            txtRestockDate.Text = AnStock.RestockDate.ToString();
            txtQuantityInStock.Text = AnStock.QuantityInStock.ToString();
            txtItemPrice.Text = AnStock.ItemPrice.ToString();
            chkIsActive.Checked = AnStock.IsActive;
        }
    }
}