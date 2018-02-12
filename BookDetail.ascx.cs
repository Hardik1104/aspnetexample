using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    public string Title
    {
        set
        {
            txtTitle.Text = value;
        }
        get
        {
            return txtTitle.Text;
        }
    }

    public string Author
    {
        get
        {
            return txtAuthor.Text;
        }
        set
        {
            txtAuthor.Text = UserCollection.currentUser.userName;
        }
    }

    public string ISBN
    {
        get
        {
            if (txtIsbn.Text.Length == 10 || txtIsbn.Text.Length == 13)
            {
                return txtIsbn.Text;
            }
            else
                return "not valid";
        }
        set
        {
            txtIsbn.Text = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}