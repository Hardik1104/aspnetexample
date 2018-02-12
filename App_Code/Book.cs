using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Book
/// </summary>
public class Book
{
    private static int id = 0;
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public string Genre { get; private set; }
    public string PageCount { get; private set; }
    public string Lent { get; private set; }
    public string FriendName { get; private set; }

    public string Description { get; private set; }


    public Book(string id,string name,string author, string isbn,string genre,string count,string lent,string friend,string description)
    {
        ID =Convert.ToInt32(id);
        Name = name;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        PageCount = count;
        Lent = lent;
        FriendName = friend;
        Description = description;
        //id++;
        

    }

}