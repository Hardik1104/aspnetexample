using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookDetail : System.Web.UI.Page
{
    Book book1;
    int ReqBook;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ReqBook = Convert.ToInt32(Request.QueryString["recipe"]);
        try
        {
            BookCollection.getBook(ReqBook);
            bookName.InnerText = BookCollection.currentBook.Name;
            author.InnerText = BookCollection.currentBook.Author;
            isbn.InnerText = BookCollection.currentBook.ISBN;
            Genre.InnerText = BookCollection.currentBook.Genre;
            count.InnerText = BookCollection.currentBook.PageCount;
            lent.InnerText = BookCollection.currentBook.Lent;
            fName.InnerText = BookCollection.currentBook.FriendName;
            description.InnerText = BookCollection.currentBook.Description;
            
        }

        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
        }
    }

    protected void DelRecipe(object sender, EventArgs e)
    {
        
        
        try
        {
            if (UserCollection.status == 1)
            {
                if (UserCollection.currentUser.userName.Equals(BookCollection.currentBook.Author))
                {

                    BookCollection.deleteBook(ReqBook);
                    lblError.Text = "1 Book Deleted!";
                    Response.Redirect("AllBooks.aspx");
                }
                else
                {
                    lblError.Text = "You can not delete information about this book.";
                }
            }
            else
            {
                lblError.Text = "Please LogIn!!";
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
        }
       
    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        if (UserCollection.status == 1)
        {
            if (UserCollection.currentUser.userName.Equals(BookCollection.currentBook.Author))
            {
                Response.Redirect("Update.aspx");
            }
            else
            {
                lblError.Text = "You can not update information about this book.";
            }

        }

        else
        {
            lblError.Text = "Please LogIn!!";
        }
        
    }
}