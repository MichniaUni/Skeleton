using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the address user class
        clsOrderUser AnUser = new clsOrderUser();
        //create the variable to store username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password enterd by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture rhe user name
        Session["AnUser"] = AnUser;
        //if username and or password is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username!";

        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a password";

        }
        //if found
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("OrderProcessingList.aspx");

        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect! Please try again.";
        }



    }
}