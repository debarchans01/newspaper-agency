using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "hello " + (string)Session["username"];
        }

    }
    protected void Add_Subscription(object sender, EventArgs e)
    {
        Response.Redirect("AddSubscriptionPage.aspx");
    }

    protected void Modify_Subscription(object sender, EventArgs e)
    {
        Response.Redirect("ModifySubscriptionPage.aspx");
    }

    protected void Billing_Details(object sender, EventArgs e)
    {
        Response.Redirect("BillinDetailsPage.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LoginPage.aspx");
    }
}