using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    //TODO: Add a static variable here to maintain no. of users to add each new U_ID to the table
    private static int user_count = 0;
    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static int User_count { get => user_count; set => user_count = value; }
}