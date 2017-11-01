using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Publishing
/// </summary>
public class Publishing
{
    //TODO: Add a static variable here to maintain no. of users to add each new P_ID to the table
    private static int publishing_count = 0;
    public Publishing()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static int Publishing_count { get => publishing_count; set => publishing_count = value; }
}