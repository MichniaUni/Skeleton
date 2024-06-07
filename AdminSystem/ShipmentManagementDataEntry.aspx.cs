using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{


    Int32 shipmentid;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number if the shipment to be updates
        shipmentid = Convert.ToInt32(Session["shipmentid"]);
        if (IsPostBack ==false)
        {
            //if this is not a new record
            if(shipmentid != -1)
            {
                //display the current data for the record
                DisplayShipment();
            }

        }

    }

    protected void btnok_Click(object sender, EventArgs e)
    {   //create a new instance of clsShipment
        clsShipment AnShipment = new clsShipment();
        //capture shipment id
        
        string ordernum = txtordernum.Text; 
        string street = txtstreet.Text;
        string city = txtcity.Text;     
        string postcode = txtpostcode.Text; 
        string deliverydate = txtdeliverydate.Text; 
        string isDeliveryExpress = chkisdeliveryexpress.Text;
        //store the shipment id in the object session
        string Error = "";
       
        Error = AnShipment.Valid(ordernum, street, city, postcode, deliverydate);
        if (Error == "")
        {
            //capture shipment id
            AnShipment.shipmentid = shipmentid;
            //capture ordernum
            AnShipment.ordernum = Convert.ToInt32(ordernum);
            AnShipment.street = street;
            AnShipment.isDeliveryExpress = chkisdeliveryexpress.Checked;
            AnShipment.city = city;
            AnShipment.postcode = postcode;
            AnShipment.deliverydate = Convert.ToDateTime(deliverydate);

            clsShipmentCollection ShipmentList = new clsShipmentCollection();
            //set the this address property
            if(Convert.ToInt32(shipmentid) == -1)
            {
                ShipmentList.ThisShipment = AnShipment;

                //add a new record
                ShipmentList.Add();
            }

            else
            {
                ShipmentList.ThisShipment.Find(Convert.ToInt32(shipmentid));
                //set the thisshipment propewrty
                ShipmentList.ThisShipment = AnShipment;
                //update the record
                ShipmentList.Update();
            }

           

          
            //navigate to  list page
            Response.Redirect("ShipmentManagementList.aspx");
        }
        else
        {
            //display the error mesage
            lblerror.Text = Error;
        }



    }

   

    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShipmentManagementList.aspx");
    }



    protected void btnfind_Click(object sender, EventArgs e)
    {
        //create an instance of the address clas
        clsShipment AnShipment = new clsShipment();
        //create a variable to store the primary key
        Int32 shipmentid;
        //create a variable to stroe the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        shipmentid = Convert.ToInt32(txtshipmentid.Text);
        //find the record
        Found = AnShipment.Find(shipmentid);
        //if found
        if (Found == true)
        {
            //display thr values of the properties in the form
            txtordernum.Text = AnShipment.ordernum.ToString();
            txtstreet.Text = AnShipment.street;
            txtcity.Text = AnShipment.city;
            txtpostcode.Text = AnShipment.postcode;
            txtdeliverydate.Text = AnShipment.deliverydate.ToString();
            chkisdeliveryexpress.Checked = AnShipment.isDeliveryExpress;
        }

    }

    void DisplayShipment()
    {
        //instance
        clsShipmentCollection ShipmentBook = new clsShipmentCollection();
        //find the record
        ShipmentBook.ThisShipment.Find(shipmentid);
        //display the daata for ythe reocrd
        txtshipmentid.Text = ShipmentBook.ThisShipment.shipmentid.ToString();    
        txtordernum.Text = ShipmentBook.ThisShipment.ordernum.ToString();
        txtstreet.Text = ShipmentBook.ThisShipment.street.ToString(); ;
        txtcity.Text = ShipmentBook.ThisShipment.city.ToString(); ;
        txtpostcode.Text = ShipmentBook.ThisShipment.postcode.ToString(); ;
        txtdeliverydate.Text = ShipmentBook.ThisShipment.deliverydate.ToString();
        chkisdeliveryexpress.Checked = ShipmentBook.ThisShipment.isDeliveryExpress;
    }
}