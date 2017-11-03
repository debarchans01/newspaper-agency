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
        if (!IsPostBack && Session["username"] != null)
        {
            Label1.Text = "hello " + (string)Session["username"];
        }
        else if(Session["username"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }

    }
    protected void Add_Subscription(object sender, EventArgs e)
    {
        
    }

    protected void Modify_Subscription(object sender, EventArgs e)
    {
        
    }

    protected void Billing_Details(object sender, EventArgs e)
    {
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LoginPage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddSubscriptionPage.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModifySubscriptionPage.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("BillinDetailsPage.aspx");
    }
}