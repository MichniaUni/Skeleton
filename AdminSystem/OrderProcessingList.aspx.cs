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
        //if this is the first time, the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

    }
    void DisplayOrders()
    {
        //create an instance of the order processing collection
        clsOrderProcessingCollection AnOrderProcessing = new clsOrderProcessingCollection();
        //set the data source to the list of addresses in the collection
        lstOrderList.DataSource = AnOrderProcessing.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "OrderStatus";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Orderid"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderProcessingDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["orderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderProcessingDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit!";
        }
    }
}