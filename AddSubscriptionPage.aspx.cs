using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddSubscriptionPage : System.Web.UI.Page
{
    string pname;
    string startdate, enddate;
    string monthlyrate;
    int rate;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "hello " + (string)Session["username"];
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRow = GridView1.SelectedIndex;
        pname = GridView1.Rows[selectedRow].Cells[1].Text;
        monthlyrate = GridView1.Rows[selectedRow].Cells[2].Text;
        int.TryParse(monthlyrate, out rate);
        Label3.Text = pname;
        Label4.Text = monthlyrate;

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime startdateobject = Calendar1.SelectedDate;
        if (startdateobject >= (DateTime.Today.AddDays(7)))
        {
            startdate = Calendar1.SelectedDate.ToShortDateString();
            Label5.Text = startdate.ToString();
        }
        else
        {
            Label7.Text = "Atleast 7 days ahead dates are allowed.";
        }

    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        DateTime enddateobject = Calendar2.SelectedDate;
        enddate = Calendar2.SelectedDate.ToShortDateString();
        Label6.Text = enddate.ToString();
    }

    protected void Confirm_Subscription(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("insert Subscription(Username, P_Name, Status, Start_date, End_date, Pause_start, Pause_end, Region, Pincode  ) VALUES(@var1, @var2, @var3, @var4, @var5, NULL, NULL,@var6, @var7)", con1);
            command.Parameters.AddWithValue("@var1", Session["username"].ToString());
            command.Parameters.AddWithValue("@var2", Label3.Text);
            command.Parameters.AddWithValue("@var3", "Active");
            DateTime startdate = Convert.ToDateTime(Label5.Text);
            command.Parameters.AddWithValue("@var4", startdate);
            DateTime enddate = Convert.ToDateTime(Label6.Text);
            command.Parameters.AddWithValue("@var5", enddate);
            command.Parameters.AddWithValue("@var6", Session["region"].ToString());
            command.Parameters.AddWithValue("@var7", Session["pincode"].ToString());
            SqlDataReader reader = command.ExecuteReader();

        }
        catch (Exception ex)
        {
            ErrorLabel.Text = ex.ToString();
        }
        finally
        {
            con1.Close();
            Response.Redirect("UserHomePage.aspx");
        }
    }
 
    protected void Reload_Page(object sender, EventArgs e)
    {

        Response.Redirect("AddSubscriptionPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserHomePage.aspx");
    }
}
