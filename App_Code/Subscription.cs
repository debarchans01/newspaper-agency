using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subscription
/// </summary>
public class Subscription
{
    //TODO: Add a static variable here to maintain no. of users to add each new S_ID to the table
    private static int subscription_count = 0;
    public Subscription()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static int Subscription_count { get => subscription_count; set => subscription_count = value; }
}