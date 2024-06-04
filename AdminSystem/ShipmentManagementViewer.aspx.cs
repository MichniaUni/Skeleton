using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //CREATE A NEW instance of clsShipment
        clsShipment AnShipment = new clsShipment();
        //get data from session object
        AnShipment = (clsShipment)Session["AnShipment"];
        //display the shipment id for the entry
        Response.Write(AnShipment.shipmentid);
        Response.Write(AnShipment.ordernum);
        Response.Write(AnShipment.street);
        Response.Write(AnShipment.postcode);
        Response.Write(AnShipment.deliverydate);
        Response.Write(AnShipment.isDeliveryExpress);
    }
}