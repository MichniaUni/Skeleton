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
        //create a new instance of clsOrderProcessing
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //capture the OrderDate
        String OrderDate = txtOrderDate.Text;
        //capture the OrderStatus
        String OrderStatus = txtOrderStatus.Text;
        //capture the PaymentMethod
        String PaymentMethod = txtPaymentMethod.Text;
        //capture the IsCancelled checkbox
        String Iscancelled = chkIsCancelled.Text;
        //variable to store any error message
        String Error = "";
        //validate the data
        Error = AnOrderProcessing.Valid(OrderDate, OrderStatus, PaymentMethod);
        if (Error == "")
        {
            //capture the OrderDate
            AnOrderProcessing.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the OrderStatus
            AnOrderProcessing.OrderStatus = OrderStatus;
            //capture the PaymentMethod
            AnOrderProcessing.PaymentMethod = PaymentMethod;
            //store the OrderProcessing in the session object
            Session["AnOrderProcesing"] = AnOrderProcessing;
            //navigate to the view page
            Response.Redirect("OrderProcessingViewer.aspx");
        }
        else
        {
            //dispay the error message
            lblError.Text = Error;
        }
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
            txtOrderDate.Text = AnOrderProcessing.OrderDate.ToString();
            txtOrderStatus.Text = AnOrderProcessing.OrderStatus;
            txtPaymentMethod.Text = AnOrderProcessing.PaymentMethod;
            chkIsCancelled.Checked = AnOrderProcessing.IsCancelled;
        }
    }
}