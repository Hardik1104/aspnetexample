using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Hardik Patel-300862521
public partial class Update : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1SRPC5I;Initial Catalog=libraryDB;Integrated Security=True");
    SqlCommand cmd;
    string sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (string item in BookCollection.allGenre)
        {
            txtGenre.Items.Add(new ListItem(item, item));
        }
        txtBookName.Text = BookCollection.currentBook.Name;
        txtAuthor.Text = BookCollection.currentBook.Author;
        txtIsbn.Text = BookCollection.currentBook.ISBN;
        txtGenre.Text = BookCollection.currentBook.Genre;
        txtCount.Text = BookCollection.currentBook.PageCount;
        //txtLent.Text = BookCollection.currentBook.Lent;
        txtFName.Text = BookCollection.currentBook.FriendName;
        txtDes.Text = BookCollection.currentBook.Description;
    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        try
        {
            sql = "UPDATE tblBookInfo SET bookName='" + txtBookName.Text + "',Author='" + txtAuthor.Text + "',ISBN='" + txtIsbn.Text + "',Genre='" + txtGenre.Text + "' ,pageCount='" + txtCount.Text + "' ,Lent='" + txtLent.Text + "' ,FriendName='" + txtFName.Text + "' ,Description='" + txtDes.Text + "' WHERE bookId=" + BookCollection.currentBook.ID;
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            int x = cmd.ExecuteNonQuery();
            cn.Close();
            clear();
            lblError.Text = BookCollection.currentBook.ID + " Book Info Updated.";
            BookCollection.loadBooks();
            Response.Redirect("AllBooks.aspx");

        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
        }

    }
    void clear()
    {
        txtAuthor.Text = "";
        txtBookName.Text = "";
        txtCount.Text = "";
        txtDes.Text = "";
        txtFName.Text = "";
        txtIsbn.Text = "";

    }
    protected void DelRecipe(object sender, EventArgs e)
    {
        string sql = "Delete from tblBookInfo where bookId=" + BookCollection.currentBook.ID;
        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            int x = cmd.ExecuteNonQuery();
            lblError.Text = x + "Book Deleted!";
        }
        catch (Exception ex)
        {

            lblError.Text = ex.ToString();
        }
        
        Response.Redirect("AllBooks.aspx");
    }
}