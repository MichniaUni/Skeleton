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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the FirstName
        string FirstName = txtFirstName.Text;
        //capture the LastName
        string LastName = txtLastName.Text;
        //capture the Age
        string Age = txtAge.Text;
        //capture the PhoneNumber
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the DateJoined
        string DateJoined = txtDateJoined.Text;
        //capture the CustomerId
        string CustomerId = txtCustomerId.Text;
        //capture the isActive
        string isActive = chkisActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
        if (Error == "")
        {
            //capture the FirstName
            ACustomer.FirstName = FirstName;
            //capture the LastName
            ACustomer.LastName = LastName;
            //capture the DateJoined
            ACustomer.DateJoined = Convert.ToDateTime(DateJoined);
            //capture the Age
            ACustomer.Age = Convert.ToInt32(Age);
            //capture the PhoneNmber
            ACustomer.PhoneNumber = Convert.ToInt64(PhoneNumber);
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect back to the view page
            Response.Redirect("CustomerManagementViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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