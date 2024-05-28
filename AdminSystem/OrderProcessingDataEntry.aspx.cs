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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsOrderProcessing
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //capture the orderID
        AnOrderProcessing.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the DateAdded
        AnOrderProcessing.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture the IsCancelled
        AnOrderProcessing.IsCancelled = chkIsCancelled.Checked;
        //capture the order status
        AnOrderProcessing.OrderStatus = txtOrderStatus.Text;
        //capture the PaymentMethod
        AnOrderProcessing.PaymentMethod = txtPaymentMethod.Text;
        //store the OrderProcessing in the session object
        Session["AnOrderProcessing"] = AnOrderProcessing;
        //navigate to the view page
        Response.Redirect("OrderProcessingViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order processing class
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //create a varaible to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrderProcessing.Find(OrderId);
        //if found
        if ( Found == true )
        {
            //display the values of the properties in the form
            txtOrderDate.Text = AnOrderProcessing.DateAdded.ToString();
            txtOrderStatus.Text = AnOrderProcessing.OrderStatus;
            txtPaymentMethod.Text = AnOrderProcessing.PaymentMethod;
            chkIsCancelled.Checked = AnOrderProcessing.IsCancelled;
        }
    }
}