using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Hardik Patel-300862521
public partial class AllBooks : System.Web.UI.Page
{
    Book book1;
    string books;
    protected void Page_Load(object sender, EventArgs e)
    {
        BookCollection.loadBooks();
        foreach (var item in BookCollection.myBooks)
        {
            books = books + "<p class='item'><a href='BookDetail.aspx?recipe=" + item.ID.ToString() + "'><span>" + item.Name + "</span></a></p>";
        }
        multiRecipe.InnerHtml = books;

    }

}