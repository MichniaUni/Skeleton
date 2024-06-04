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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the clsSupplier
        clsSupplier AnSupplier= new clsSupplier();
        //create a variable to store the primary key
        Int32 SupplierID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //find the record
        Found = AnSupplier.Find(SupplierID);
        //if found
        if (Found ==true) {
            //display the values of the properties in the form
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtExpiryDate.Text= AnSupplier.ExpiryDate.ToString();
            txtQuantity.Text = AnSupplier.Quantity.ToString();
            txtPrice.Text = AnSupplier.Price.ToString();
            txtProductionDate.Text = AnSupplier.ProductionDate.ToString();
            chkShipped.Checked = AnSupplier.Shipmentstatus;
        }

    }
}