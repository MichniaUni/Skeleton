using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable for primary key
    Int32 shipmentid;
    protected void Page_Load(object sender, EventArgs e)
    {
        shipmentid = Convert.ToInt32(Session["shipmentid"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        //create a neew instance
        clsShipmentCollection ShipmentBook = new clsShipmentCollection();   
        //find the record
        ShipmentBook.ThisShipment.Find(shipmentid);
        //delete the record
        ShipmentBook.Delete();
        //redirect to main page
        Response.Redirect("ShipmentManagementList.aspx");
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
        //reidrect to main page
        Response.Redirect("ShipmentManagementList.aspx");
    }
}