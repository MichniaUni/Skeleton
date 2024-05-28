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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of the record to be edited
        Int32 ItemId;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ItemId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ItemId"] = ItemId;
            //redirect to the edit page
            Response.Redirect("StockManagementDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the lit to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of record to be deleted
        Int32 ItemId;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            ItemId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ItemId"] = ItemId;
            //redirect to the delete page
            Response.Redirect("StockManagementConfirmDelete.aspx");
        }
        //if no records has been selected
        else
        {
            //display an error message
            lblError.Text = "Please select a record from the list to be delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStockCollection AnStock = new clsStockCollection();
        //retrieve the value of itemdescription from the presentation layer
        AnStock.ReportByItemDescription(txtFilterData.Text);
        //set the data sourse to the list of item description in the collection
        lstStockList.DataSource = AnStock.ItemList;
        //set the name of the primary key
        lstStockList.DataValueField = "ItemId";
        //set the name of the filds to display
        lstStockList.DataTextField = "ItemDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
      //add code here
    }
}