using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    private string id;
    public string userName;
    public string password;
    public User(string id,string name,string pass)
    {
        this.id = id;
        userName = name;
        password = pass;
    }
}