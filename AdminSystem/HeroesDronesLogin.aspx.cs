using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HeroesDronesLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //creazte an instance of the Heroes user class
        clsStockUser AnUser = new clsStockUser();
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
            //redirect to the List page
            Response.Redirect("StockManagementList.aspx");
        }
        else if (Found == false)
        {
            //recoprd the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}