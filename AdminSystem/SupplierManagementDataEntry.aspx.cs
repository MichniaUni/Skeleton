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

    protected void btnadd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture Supplier name
        AnSupplier.SupplierName = txtSupplierName.Text;
        //capture SupplierID
        AnSupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //Capture ProductionDate
        AnSupplier.ProductionDate= Convert.ToDateTime(txtProductionDate.Text);
        //Capture Expiry date
        AnSupplier.ExpiryDate= Convert.ToDateTime(txtExpiryDate.Text);
        //capture quantity
        AnSupplier.Quantity = Convert.ToInt32(txtQuantity.Text);
        //capture price
        AnSupplier.Price = Convert.ToInt32(txtPrice.Text);
        //capture Shipmentstatus
        AnSupplier.Shipmentstatus= chkShipped.Checked;

        //store the supplier in the session object
        Session["AnSupplier"] = AnSupplier;
        //redirect to view page
        Response.Redirect("SupplierManagementViewer.aspx");
    }

    protected void chkProcessing_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierManagementViewer.aspx");
    }

    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

    }
}