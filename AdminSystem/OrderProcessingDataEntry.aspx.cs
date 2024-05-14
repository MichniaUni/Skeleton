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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsOrderProcessing
        clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
        //capture the OrderId
        AnOrderProcessing.OrderId = Convert.ToInt32(txtOrderId.Text);
        //store the OrderProcessing in the session object
        Session["AnOrderProcessing"] = AnOrderProcessing;
        //navigate to the view page
        Response.Redirect("OrderProcessingViewer.aspx");
    }
}