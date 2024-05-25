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
}