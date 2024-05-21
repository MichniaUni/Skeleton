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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];


        //display the First Name for this entry
        Response.Write(ACustomer.FirstName);
        //display the Last Name for this entry
        Response.Write(ACustomer.LastName);

        //display the Last Name for this entry
        Response.Write(ACustomer.Age);
        //display the Last Name for this entry
        Response.Write(ACustomer.PhoneNumber);
        //display the Last Name for this entry
        Response.Write(ACustomer.DateJoined);
        //display the Last Name for this entry
        Response.Write(ACustomer.isActive);
        //display the Last Name for this entry
        Response.Write(ACustomer.CustomerId);
    }
}