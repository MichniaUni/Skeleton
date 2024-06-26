﻿using System;
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to stre primary key
        Int32 shipmentid;
        //if record has been selected from the list
        if(lstshipmentlist.SelectedIndex != -1)
        {
            //gte the primary key value
            shipmentid = Convert.ToInt32(lstshipmentlist.SelectedValue);
            //store session
            Session["shipmentid"]= shipmentid;
            //redirect
            Response.Redirect("ShipmentManagementDataEntry.aspx");

        }
        //if no record has been selected
        else
        {
            lblError.Text = "please selecet a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to stre primary key
        Int32 shipmentid;
        //if record has been selected from the list
        if (lstshipmentlist.SelectedIndex != -1)
        {
            //gte the primary key value
            shipmentid = Convert.ToInt32(lstshipmentlist.SelectedValue);
            //store session
            Session["shipmentid"] = shipmentid;
            //redirect
            Response.Redirect("ShipmentManagementConfirmDelete.aspx");

        }
        //if no record has been selected
        else
        {
            lblError.Text = "please selecet a record from the list to Delete";
        }
    }

    protected void btnapply_Click(object sender, EventArgs e)
    {
        clsShipmentCollection AnShipment = new clsShipmentCollection();
        AnShipment.ReportByPostCode(txtepostcode.Text);

        lstshipmentlist.DataSource = AnShipment.ShipmentList;

        lstshipmentlist.DataValueField = "shipmentid";

        lstshipmentlist.DataTextField = "postcode";

        lstshipmentlist.DataBind(); 
    }

    protected void btnclear_Click(object sender, EventArgs e)
    {

        clsShipmentCollection AnShipment = new clsShipmentCollection();
        AnShipment.ReportByPostCode("");

        txtepostcode.Text = "";

        lstshipmentlist.DataSource = AnShipment.ShipmentList;

        lstshipmentlist.DataValueField = "shipmentid";

        lstshipmentlist.DataTextField = "postcode";

        lstshipmentlist.DataBind();
    }
}