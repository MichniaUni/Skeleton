using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the customer user class
        clsCustomerUser AnUser = new clsCustomerUser();
        //create the variable to store the user name and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create the variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture the user name
        Session["AnUser"] = AnUser;
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter the User Name";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter Password";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the customer list page
            Response.Redirect("CustomerManagementList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Your login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}