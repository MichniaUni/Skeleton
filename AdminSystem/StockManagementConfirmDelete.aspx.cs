using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key values of the record to be deleted
    Int32 ItemId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        ItemId = Convert.ToInt32(Session["ItemId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Item stock collection class
        clsStockCollection ItemBook = new clsStockCollection();
        //find the record to delete
        ItemBook.ThisItem.Find(ItemId);
        //delete the record
        ItemBook.Delete();
        //redirect back to main page
        Response.Redirect("StockManagementList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockManagementList.aspx");
    }
}