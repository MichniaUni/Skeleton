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
        //if this is the first time apge displyed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayShipments();
        }
    }

    void DisplayShipments()
    {
        //Create an instance of the shpment collection
        clsShipmentCollection Shipments = new clsShipmentCollection();
        //set the data sources to list of addresses in th ecollection
        lstshipmentlist.DataSource = Shipments.ShipmentList;
        //SET THE NAME OF PRIMARY KEY
        lstshipmentlist.DataValueField = "shipmentid";
        //set the data firld to display
        lstshipmentlist.DataTextField = "postcode";
        //bind the data to the list
        lstshipmentlist.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicatae thisis a new record
        Session["shipmentid"] = -1;
        //redirect to the data entry page
        Response.Redirect("ShipmentManagementDataEntry.aspx");
    }
}