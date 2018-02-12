using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserCollection
/// </summary>
public class UserCollection
{
    //connection string
    private static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1SRPC5I;Initial Catalog=libraryDB;Integrated Security=True");
    private static SqlCommand cmd;
    static Book book1;
    static string sql;
    //currentUser willsave infomation about User currently logged In
    public static User currentUser;
    //this List will save all Information about users
    public static List<User> allUser;
    public static int status = 0;
    public UserCollection()
    {
        
    }
   
    public static void AddUser(User user)
    {
        try
        {
            //this method will called in signUp page to add new User into Database
            string sql = "Insert Into tblUserInfo(userName,password)values('" + user.userName + "','" + user.password + "')";
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd = new SqlCommand(sql, cn);
            //execute single sql statement
            int x = cmd.ExecuteNonQuery();
            cn.Close();
        }
        catch
        {
            cn.Close();
        }

    }
    public static void loadUser()
    {
        //This Method will be called at begnning to get all Information about User
        string id, name, pass;
        if (allUser == null) { allUser = new List<User>(); }
        sql = "Select userId,userName,password from tblUserInfo";
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd = new SqlCommand(sql, cn);
        //this loop will go through all rows in tblUserInfo and save it into List
        using (SqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                id = rdr[0].ToString();
                id = id.Replace(" ", "");
                name = rdr[1].ToString();
                name = name.Replace(" ", "");
                pass = rdr[2].ToString();
                pass = pass.Replace(" ", "");

                allUser.Add(new User(id, name, pass));

            }
        }
    }
}