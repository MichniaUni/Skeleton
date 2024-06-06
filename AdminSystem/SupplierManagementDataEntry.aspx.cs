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
        //capture supplier name
        string SupplierName= txtSupplierName.Text;
        //capture Production date
        string ProductionDate =txtProductionDate.Text;
        //capture Expiry date
        string ExpiryDate=txtExpiryDate.Text;
        //capture quantity
        string Quantity = txtQuantity.Text;
        //capture price
        string Price = txtPrice.Text;
        //capture shipmentsatatus
        string Shipmentstatus= chkShipped.Text;
        // variable to store any error message
        string Error = "";
        //validate the data
        Error = AnSupplier.Valid(SupplierName, ProductionDate, ExpiryDate, Quantity, Price);
        if (Error == "")
        {
            
            //capture Supplier name
            AnSupplier.SupplierName = SupplierName;
            
            //Capture ProductionDate
            AnSupplier.ProductionDate = Convert.ToDateTime(ProductionDate);
            //Capture Expiry date
            AnSupplier.ExpiryDate = Convert.ToDateTime(ExpiryDate);
            //capture quantity
            AnSupplier.Quantity = Convert.ToInt32(Quantity);
            //capture price
            AnSupplier.Price = Convert.ToInt32(Price);
            //capture shipmentstatus
            AnSupplier.Shipmentstatus= chkShipped.Checked;
            //create a new instance of the supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //set the thissupplier property
            SupplierList.ThisSupplier = AnSupplier;
            //add new record
            SupplierList.Add();
            //redirect to back to list page
            Response.Redirect("SupplierManagementList.aspx");
            

   
        }

        else
        {
            // display the error message
            lblError.Text= Error;
        }
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