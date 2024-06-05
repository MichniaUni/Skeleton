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
        //create a new instance of clsOrderProcessing
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //get the data from the session object
        AnOrderProcessing = (clsOrderProcessing)Session["AnOrderProcessing"];
        //display the order id for this entry
        Response.Write(AnOrderProcessing.OrderId);
        //display the date added for the entry
        Response.Write(AnOrderProcessing.OrderDate);
        //display the Iscancelled for the entry
        Response.Write(AnOrderProcessing.IsCancelled);
        //display the order status for the entry
        Response.Write(AnOrderProcessing.OrderStatus);
        //display the payment method for the entry
        Response.Write(AnOrderProcessing.PaymentMethod);

    }
}