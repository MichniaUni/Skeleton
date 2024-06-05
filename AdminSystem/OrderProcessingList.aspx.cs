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
}