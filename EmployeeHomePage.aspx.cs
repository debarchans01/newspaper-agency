using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class EmployeeHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["username"] != null)
        {
            Label1.Text = "Welcome " + (string)Session["username"];
        }
        else if (Session["username"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

   /* protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedItem.Text.Equals("Change Theme"))
        {
            Session["theme"] = "change";
            Label2.Text = "Theme changed";
            Response.Redirect(Request.FilePath);
        }
        else if(DropDownList1.SelectedItem.Text.Equals("Select Delivery Region"))
        {
            string username = Session["username"].ToString();
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            try
            {
                con1.Open();
                SqlCommand command = new SqlCommand("select distinct Region from Users", con1);
                
                SqlDataReader reader = command.ExecuteReader();
                DropDownList2.Visible = true;
                while (reader.Read())
                {
                    DropDownList2.Items.Add(reader["Region"].ToString());
                }
            }
            catch (Exception ex)
            {
                
                Label2.Visible = true;
                Label2.Text = ex.ToString();
            }
            finally
            {
                con1.Close();
            }
        }
    }*/

    protected void Button1_Click(object sender, EventArgs e)
    {
        string region = RadioButtonList1.SelectedItem.Text;
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            //SqlCommand command = new SqlCommand("select sum(Monthly_Rate) 'total' from Publishing where P_Name in (select P_Name from Subscription where Region=@var1)",con1);
            SqlCommand command = new SqlCommand("select sum(Monthly_Rate) 'total' from Subscription where Region=@var1;", con1);
            command.Parameters.AddWithValue("@var1", region);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int total = int.Parse(reader["total"].ToString());
            double commission = total * 0.025;
            Label2.Text = "Total commssion is Rs." + commission.ToString();
        }
        catch(Exception ex)
        {
            Label2.Text = ex.ToString();
        }
        finally
        {
            con1.Close();
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //sqlDB.SelectParameters.Add(DropDownList2.SelectedItem.Text);
        Label2.Text = "";
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["theme"] != null)
        {
            Page.Theme = "EmpPgTheme1";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("LoginPage.aspx");
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}