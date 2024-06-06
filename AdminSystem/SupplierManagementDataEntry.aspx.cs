using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the pk value with page level scope
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack==false)
        {
            //if this is not a new record
            if (SupplierID != -1)
            {
                //diplay the current data for the record
                DisplaySupplier();
            }
        }
    }

    public void DisplaySupplier()
    {
        //create an instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(SupplierID);
        //display the data for the record
        txtSupplierID.Text= SupplierBook.ThisSupplier.SupplierID.ToString();
        txtSupplierName.Text= SupplierBook.ThisSupplier.SupplierName.ToString();
        txtProductionDate.Text= SupplierBook.ThisSupplier.ProductionDate.ToString();
        txtExpiryDate.Text= SupplierBook.ThisSupplier.ExpiryDate.ToString();
        txtPrice.Text= SupplierBook.ThisSupplier.Price.ToString();
        txtQuantity.Text=SupplierBook.ThisSupplier.Quantity.ToString();
        chkShipped.Checked = SupplierBook.ThisSupplier.Shipmentstatus;

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
            //capture supplierid
            AnSupplier.SupplierID = SupplierID;
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
            //if this is a new record i.e. supplierid =-1 then add the data
            if (SupplierID == -1)
            {


                //set the thissupplier property
                SupplierList.ThisSupplier = AnSupplier;
                //add new record
                SupplierList.Add();

            }
            //otherwise it must be an update

            else
            {
                //find thr recordto update
                SupplierList.ThisSupplier.Find(SupplierID);
                //set thissupplier propery
                SupplierList.ThisSupplier= AnSupplier;
                //update the record
                SupplierList.Update();
            }
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