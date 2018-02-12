using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//Hardik Patel-300862521
/// <summary>
/// Summary description for BookCollection
/// </summary>
public class BookCollection
{
    //connection string for server
    private static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1SRPC5I;Initial Catalog=libraryDB;Integrated Security=True");
    private static SqlCommand cmd;
    //curretBook will save the current book selected
    public static Book currentBook;
    //In this List I will save all books from database
    public static List<Book> myBooks;
    //In this list I ill save all genre from database 
    public static List<string> allGenre;

    public BookCollection()
    {

    }
    public static void deleteBook(int x)
    {
        //delete book method
        string sql = "Delete from tblBookInfo where bookId=" + x;
        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            int x1 = cmd.ExecuteNonQuery();

            cn.Close();
            
        }
        catch
        {

            cn.Close();
        }
    }
    public static void AddBook(Book book1)
    {
        //this method will be called to add book in database
        try
        {
            string sql = "Insert Into tblBookInfo(bookName,Author,ISBN,Genre,pageCount,Lent,FriendName,Description)values('" + book1.Name + "','" + book1.Author + "','" + book1.ISBN + "','" + book1.Genre + "','" + book1.PageCount + "','" + book1.Lent + "','" + book1.FriendName + "','" + book1.Description + "')";
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            int x = cmd.ExecuteNonQuery();
            cn.Close();
        }
        catch 
        {
           
            cn.Close();
        }
    }

    public static void AddGenre(string genre)
    {
        //this method will be called to add new Genre in database
        string sql = "Insert Into tblGenre(genre) values('" + genre + "')";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(sql, cn);

        int x = cmd.ExecuteNonQuery();
        cn.Close();
    }
    public static void loadGenre()
    {
        //In this method we will add all genre from database to List<string> allgenre
        allGenre = new List<string>();
        string genre = "";
        string sql = "Select genre from tblGenre";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(sql, cn);
        //looping through all data raw in tblGenre
        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                genre = rdr[0].ToString();
                genre = genre.Replace(" ", "");
                allGenre.Add(genre);

            }
            cn.Close();
        }

    }
    public static void getBook(int x)
    {
        //this method will be called to get book 
        string id, name, autho, isb, genre, coun, len, fname, descri;
        string sql = "Select bookId,bookName,Author,ISBN,Genre,pageCount,Lent,FriendName,Description from tblBookInfo where bookId=" + x;
        try
        {
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    id = rdr[0].ToString();
                    id = id.Replace(" ", "");
                    name = rdr[1].ToString();
                    name = name.Replace(" ", "");
                    autho = rdr[2].ToString();
                    autho = autho.Replace(" ", "");
                    isb = rdr[3].ToString();
                    isb = isb.Replace(" ", "");
                    genre = rdr[4].ToString();
                    genre = genre.Replace(" ", "");
                    coun = rdr[5].ToString();
                    coun = coun.Replace(" ", "");
                    len = rdr[6].ToString();
                    len = len.Replace(" ", "");
                    fname = rdr[7].ToString();
                    fname = fname.Replace(" ", "");
                    descri = rdr[8].ToString();
                    descri = descri.Replace("  ", "");
                    currentBook = new Book(id, name, autho, isb, genre, coun, len, fname, descri);


                }
                
            }
            
        }

        catch
        {

            cn.Close();
        }
        
    }
    public static void loadBooks()
    {

        myBooks = new List<Book>();
        string id, name, author, isbn, genre, count, lent, fname, descri;
        myBooks = new List<Book>();
        //creating sql command that select all coloumn from tblBookInfo
        string sql = "Select bookId,bookName,Author,ISBN,Genre,pageCount,Lent,FriendName,Description from tblBookInfo";
        //check if connection is open or not
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(sql, cn);
        //will read all raw of data and it will add everything into list
        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                id = rdr[0].ToString();
                id = id.Replace(" ", "");
                name = rdr[1].ToString();
                name = name.Replace(" ", "");
                author = rdr[2].ToString();
                author = author.Replace(" ", "");
                isbn = rdr[3].ToString();
                isbn = isbn.Replace(" ", "");
                genre = rdr[4].ToString();
                genre = genre.Replace(" ", "");
                count = rdr[5].ToString();
                count = count.Replace(" ", "");
                lent = rdr[6].ToString();
                lent = lent.Replace(" ", "");
                fname = rdr[7].ToString();
                fname = fname.Replace(" ", "");
                descri = rdr[8].ToString();
                descri = descri.Replace("  ", "");
                myBooks.Add(new Book(id, name, author, isbn, genre, count, lent, fname, descri));

            }
        }
    }
}