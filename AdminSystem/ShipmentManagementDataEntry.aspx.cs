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

    protected void btnok_Click(object sender, EventArgs e)
    {   //create a new instance of clsShipment
        clsShipment AnShipment = new clsShipment();
        //capture shipment id
        AnShipment.shipmentid = Convert.ToInt32(txtshipmentid.Text);
        //capture order id
        AnShipment.ordernum = Convert.ToInt32(txtordernum.Text);
        //capture street
        AnShipment.street = txtstreet.Text;
        //capture city
        AnShipment.city = txtcity.Text;
        //capture postcode
        AnShipment.postcode = txtpostcode.Text;
        //capture deliverydate
        AnShipment.deliverydate = Convert.ToDateTime(DateTime.Now);
        //capture Expressdelivery
        AnShipment.isDeliveryExpress = chkisdeliveryexpress.Checked;
        //store the shipment id in the object session
        Session["AnShipment"]=AnShipment;
        //navigate to viewer page
        Response.Redirect("ShipmentManagementViewer.aspx");
    }
}