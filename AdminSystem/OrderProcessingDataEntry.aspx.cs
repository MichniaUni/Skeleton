using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the orderProcessing to be processed 
        OrderId = Convert.ToInt32(Session["Orderid"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
       
    }
    void DisplayOrder()
    {
        //create an instance of the order book
        clsOrderProcessingCollection OrderBook = new clsOrderProcessingCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtOrderStatus.Text = OrderBook.ThisOrder.ToString();
        txtPaymentMethod.Text = OrderBook.ThisOrder.PaymentMethod.ToString();
        chkIsCancelled.Checked = OrderBook.ThisOrder.IsCancelled;


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
            //capture the OrderId
            AnOrderProcessing.OrderId = OrderId; //Dont miss this bit !!!its important
            //capture the OrderDate
            AnOrderProcessing.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the OrderStatus
            AnOrderProcessing.OrderStatus = OrderStatus;
            //capture the PaymentMethod
            AnOrderProcessing.PaymentMethod = PaymentMethod;
            //capture IsCancelled
            AnOrderProcessing.IsCancelled = chkIsCancelled.Checked;
            //create a new instance of the order processing collection
            clsOrderProcessingCollection OrderList = new clsOrderProcessingCollection();
            //if this is a new record .i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrderProcessing;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder Property
                OrderList.ThisOrder = AnOrderProcessing;
                //update the record
                OrderList.Update();
            }
            //redirect back to the list page
            Response.Redirect("OrderProcessingList.aspx");
           
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