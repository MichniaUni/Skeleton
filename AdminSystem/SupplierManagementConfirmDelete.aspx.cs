using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the pk value of the record to be deleted
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instsnce
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(SupplierID);
        //delete the record
        SupplierBook.Delete();
        //redirect back to mainpage
        Response.Redirect("SupplierManagementList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierManagementList.aspx");
    }
}