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
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        //find the record to update
        customerCollection.ThisCustomer.Find(CustomerId);
        //display the data for the record
        txtCustomerId.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        txtFirstName.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        txtLastName.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        txtAge.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        txtDateJoined.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        txtPhoneNumber.Text = customerCollection.ThisCustomer.CustomerId.ToString();
        chkisActive.Text = customerCollection.ThisCustomer.CustomerId.ToString();
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
        //capture the isActive
        string isActive = chkisActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, Age, PhoneNumber, DateJoined);
        if (Error == "")
        {
            //capture CustomerId 
            ACustomer.CustomerId = Convert.ToInt32(CustomerId);
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
            //capture active
            ACustomer.isActive = chkisActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find th record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerManagementList.aspx");
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