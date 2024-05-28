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
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }

    }

    void DisplayStock()
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of stock in the collection
        lstStockList.DataSource = Stock.ItemList;
        //set the name of the primary key
        lstStockList.DataValueField = "ItemId";
        //set the data field to display
        lstStockList.DataTextField = "ItemDescription";
        //bindthe data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ItemId"] = -1;
        //redirect to the data enty page
        Response.Redirect("StockManagementDataEntry.aspx");
    }
}