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
        //---------------------------create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();





        //capture the FirstName
        ACustomer.FirstName = txtFirstName.Text;
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the LastName
        ACustomer.LastName = txtLastName.Text;
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the Age
        ACustomer.Age = Convert.ToInt32(txtAge.Text);
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the PhoneNumber
        ACustomer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the DateJoined
        ACustomer.DateJoined = Convert.ToDateTime(DateTime.Now);
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the isActive
        ACustomer.isActive = chkisActive.Checked;
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;

        //capture the CustomerId
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;


        //-----------------------------navigate to the view page
        Response.Redirect("CustomerManagementViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true) 
        {
            //display the values of the properties in the form
            txtAge.Text = ACustomer.Age.ToString();
            txtPhoneNumber.Text = ACustomer.PhoneNumber.ToString();
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtDateJoined.Text = ACustomer.DateJoined.ToString();    
            chkisActive.Checked = ACustomer.isActive;
        }

    }
}