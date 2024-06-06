using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first tine the page is displayed
        if(IsPostBack==false)
        {
            //update the listbox
            DisplaySuppliers();

        }

    }
    void DisplaySuppliers()
    {
        //create an instance of supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to list of address in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        //set the data field to display
        lstSupplierList.DataTextField = "SupplierName";
        //bind the data to trhe list
        lstSupplierList.DataBind(); 
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplierID"] = -1;
        //redirect to data entry page
        Response.Redirect("SupplierManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the pk value of the record to be edited
        Int32 SupplierID;
        //if record has been selected from the list
        if(lstSupplierList.SelectedIndex != -1)
        {
            //get the pk value of record to edit
            SupplierID= Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["SupplierID"] = SupplierID;
            //redirect to edit page
            Response.Redirect("SupplierManagementDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Plese select a record from the list to edit";
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        //variable to store the pk value of the record to be deleted
        Int32 SupplierID;
        //if record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get the pk value of record to delete
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["SupplierID"] = SupplierID;
            //redirect to delete page
            Response.Redirect("SupplierManagementConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Plese select a record from the list to delete";
        }
    }
}
