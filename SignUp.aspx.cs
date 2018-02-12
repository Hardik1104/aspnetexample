using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        if (txtPassword.Text.Equals(txtPasswordConfirm.Text))
        {
            try
            {
                UserCollection.AddUser(new User("0", txtUser.Text, txtPassword.Text));
            }
            catch (Exception ex)
            {

                lblError.Text = ex.ToString();
            }

        }
        else
        {
            lblError.Text = "Password doesn't Match";
        }
    }
}