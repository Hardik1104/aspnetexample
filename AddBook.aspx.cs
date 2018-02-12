using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class AddBook : System.Web.UI.Page
{
    
    Book book1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (UserCollection.status == 0)
        {
            lblErro.Text = "Please LogIn";
            return;
        }
        if (BookCollection.myBooks == null) { BookCollection.myBooks = new List<Book>(); }
        //if (BookCollection.allGenre == null) { BookCollection.allGenre = new List<string>(); }
        if (UserCollection.allUser == null) { UserCollection.allUser = new List<User>(); }
        loadGenre();
        bookDetail.Author = UserCollection.currentUser.userName;
    }
    void clear()
    {
        txtComments.InnerText = "";
        txtFriendName.Text = "";
        //txtGenre.Text = "";
        txtNumPages.Text = "";
        

    }
    void loadGenre()
    {
        //this method load all genre into drop
        ddGenre.Items.Clear();
        BookCollection.allGenre = new List<string>();
        //calling loadGenre method in BookCollection Class
        BookCollection.loadGenre();
       
        try
        {
            foreach (string item in BookCollection.allGenre)
            {

                ddGenre.Items.Add(new ListItem(item,item));
            }
        }
        catch (Exception ex)
        {

            lblErro.Text = ex.Message;
        }

    }
    protected void saveButton_Click(object sender, EventArgs e)
    {
        //with this method it will add book into database

        book1 = new Book("0",bookDetail.Title, bookDetail.Author, bookDetail.ISBN, ddGenre.Text, txtNumPages.Text, cbLent.Text, txtFriendName.Text, txtComments.InnerText);
        
        
        try
        {
            //Calling AddBook Method from BookCollection Class
            BookCollection.AddBook(book1);
            clear();
            lblErro.Text = "1 record(s) saved";


        }
        catch (Exception ex)
        {
            lblErro.Text = ex.Message;
            //cn.Close();
        }
        

    }
    protected void cancelButton_Click(object sender, EventArgs e)
    {
        clear();
        Response.Redirect("AddBook.aspx");
    }
    

    protected void btnAddGenre_Click(object sender, EventArgs e)
    {
        if (txtNewGenre.Text == "")
        {
            txtNewGenre.Focus();
            lblErro.Text = "Please Add Genre in Text box";
        }
        try
        {
            //calling addgenre method to add new genre into database 
            BookCollection.AddGenre(txtNewGenre.Text);
            //lblErro.Text = x + " Genre Added";
            loadGenre();
            txtNewGenre.Text = "";
        }
        catch (Exception ex)
        {

            lblErro.Text=ex.ToString();
        }
        
        
        //ddGenre.Items.Add(new ListItem("NewGenre"));
        
    }
}