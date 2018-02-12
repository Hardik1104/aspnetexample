using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class LogIn : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (UserCollection.status == 1)
        {
            UserCollection.status = 0;

        }
        UserCollection.loadUser();
        
    }
    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        foreach (var item in UserCollection.allUser)
        {
            if (item.userName.Equals(txtUser.Text) && item.password.Equals(txtPassword.Text))
            {
                UserCollection.currentUser = item;
                UserCollection.status = 1;
                Response.Redirect("AllBooks.aspx");
            }
        }
    }
}