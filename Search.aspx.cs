using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Search : System.Web.UI.Page
{
    string books;
    protected void Page_Load(object sender, EventArgs e)
    {
        books = " ";
        ddFriend.Items.Clear();
        ddGenre.Items.Clear();
        ddFriend.Items.Add(new ListItem("All", "All"));
        ddGenre.Items.Add(new ListItem("All", "All"));

        if (BookCollection.myBooks != null)
        {
            foreach (var item in BookCollection.myBooks)
            {
                ddFriend.Items.Add(new ListItem(item.FriendName, item.FriendName));
            }

        }
        else
        {
            BookCollection.loadBooks();
            foreach (var item in BookCollection.myBooks)
            {
                ddFriend.Items.Add(new ListItem(item.FriendName, item.FriendName));
            }
        }
        if (BookCollection.allGenre != null)
        {
            foreach (string item in BookCollection.allGenre)
            {
                ddGenre.Items.Add(new ListItem(item, item));
            }
        }
        else
        {
            BookCollection.loadGenre();
            foreach (var item in BookCollection.allGenre)
            {
                ddGenre.Items.Add(new ListItem(item, item));
            }
        }
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {

    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        if (!ddGenre.SelectedItem.Value.ToString().Equals("All") && ddGenre.SelectedItem.Value.ToString().Equals("All"))
        {
            foreach (var item in BookCollection.myBooks)
            {
                if (item.FriendName.Contains(ddFriend.Text) && item.Genre.Contains(ddGenre.Text))
                {
                    books = books + "<p class='item'><a href='BookDetail.aspx?recipe=" + item.ID.ToString() + "'><span>" + item.Name + "</span></a></p>";

                }

            }
        }
        if (!ddFriend.Text.Equals("All") && ddGenre.Text.Equals("All"))
        {
            foreach (var item in BookCollection.myBooks)
            {
                if (item.FriendName.Contains(ddFriend.Text))
                {
                    books = books + "<p class='item'><a href='BookDetail.aspx?recipe=" + item.ID.ToString() + "'><span>" + item.Name + "</span></a></p>";

                }

            }

        }
        if (ddFriend.Text == "All" && !ddGenre.Text.Equals("All"))
        {
            foreach (var item in BookCollection.myBooks)
            {
                if (item.Genre.Contains(ddGenre.Text))
                {
                    books = books + "<p class='item'><a href='BookDetail.aspx?recipe=" + item.ID.ToString() + "'><span>" + item.Name + "</span></a></p>";

                }

            }

        }
        if (ddGenre.Text.Equals("All") && ddFriend.Text.Equals("All"))
        {
            foreach (var item in BookCollection.myBooks)
            {
                books = books + "<p class='item'><a href='BookDetail.aspx?recipe=" + item.ID.ToString() + "'><span>" + item.Name + "</span></a></p>";


            }
        }
        if (books == " ")
        {
            searchedItems.InnerHtml = "There is no books with Record for Friend Name:" + ddFriend.Text + " and Genre:" + ddGenre.Text;
        }
        searchedItems.InnerHtml = books;


    }
}