using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModifySubscriptionPage : System.Web.UI.Page
{
    DateTime startdateobject;
    DateTime enddateobject;
    int subscription_id;

    DateTime startdatesubscription;
    DateTime enddatesubscription;
    
    string pname;
    string monthlyrate;
    string status;

    int Calendar1Flag = 1;
    int Calendar2Flag = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Label1.Text = "hello " + (string)Session["username"];
            Label5.Visible = false;
            TextBox1.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Label2.Visible = false;
            Calendar1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Calendar2.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;

        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(RadioButtonList1.SelectedIndex.Equals(0))
        {
            Label5.Visible = false;
            TextBox1.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;

            Label2.Visible = true;
            Calendar1.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Calendar2.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
            Label9.Visible = true;
        }
        else
        {
            Label2.Visible = false;
            Calendar1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Calendar2.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
            Label9.Visible = false;

            Label5.Visible = true;
            TextBox1.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRow = GridView1.SelectedIndex;
        subscription_id = Convert.ToInt32(GridView1.Rows[selectedRow].Cells[1].Text);
        Label9.Text = subscription_id.ToString();
        pname = GridView1.Rows[selectedRow].Cells[2].Text;
        status = GridView1.Rows[selectedRow].Cells[3].Text;
        startdatesubscription = Convert.ToDateTime(GridView1.Rows[selectedRow].Cells[4].Text);
        enddatesubscription = Convert.ToDateTime(GridView1.Rows[selectedRow].Cells[5].Text);

        TextBox1.Text = "Subscription ID - " + subscription_id + "Start Date - " + startdatesubscription.ToShortDateString() + "End Date - " + enddatesubscription.ToShortDateString();
        
    }


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        startdateobject = Calendar1.SelectedDate;
        if (startdateobject >= (DateTime.Today.AddDays(7)))
        {
            string startdate = Calendar1.SelectedDate.ToShortDateString();
            if(startdateobject < startdatesubscription || startdateobject < DateTime.Today)
            {
                Label6.Text = "Invalid Date, Select Valid Date";
                Calendar1Flag = 0;
            }
            else
            {
                Calendar1Flag = 1;
                Label7.Text = startdate;
            }


        }
        else
        {
            Label6.Text = "Atleast 7 days ahead dates are allowed.";
        }
    }


    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        enddateobject = Calendar2.SelectedDate;
        string enddate = Calendar2.SelectedDate.ToShortDateString();
        Label8.Text = enddate;
 
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if(Calendar1Flag==0)
        {
            Label1.Text = "Failed due to invalid dates, Try Again.";
        }
        //else if(status.Equals("Paused"))
        //{
        //    Label1.Text = "Failed because subscription already paused. Try with a different subscription.";
        //}
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("UPDATE Subscription set Pause_start = @var1, Pause_end = @var2, Status = @var3 WHERE Username =@var4 AND S_ID = @var5; ", con1);
            DateTime startdate = Convert.ToDateTime(Label7.Text);
            //command.Parameters.AddWithValue("@var5", startdatesubscription);
            
            command.Parameters.AddWithValue("@var1", startdate);
            DateTime enddate = Convert.ToDateTime(Label8.Text);
            command.Parameters.AddWithValue("@var2", enddate);
            command.Parameters.AddWithValue("@var3", "Paused");
            command.Parameters.AddWithValue("@var4", Session["username"].ToString());
            command.Parameters.AddWithValue("@var5", Convert.ToInt32(Label9.Text));
            //DateTime startdate = Convert.ToDateTime(Label5.Text);
            //command.Parameters.AddWithValue("@var5", startdatesubscription);
            // DateTime enddate = Convert.ToDateTime(Label6.Text);
            //command.Parameters.AddWithValue("@var6", enddatesubscription);
            //command.Parameters.AddWithValue("@var6", Session["region"].ToString());
            //command.Parameters.AddWithValue("@var7", Session["pincode"].ToString());
            SqlDataReader reader = command.ExecuteReader();
        }
        catch(Exception ex)
        {
            ErrorLabel.Text = ex.ToString();
        }
        finally
        {
            con1.Close();
            Response.Redirect("UserHomePage.aspx");
        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("UPDATE Subscription set End_date = @var1,  Status = @var2 WHERE Username =@var4 AND S_ID = @var5; ", con1);
            DateTime cancelleddate = Convert.ToDateTime(DateTime.Today);

            command.Parameters.AddWithValue("@var1", cancelleddate);
        
            command.Parameters.AddWithValue("@var2", "Cancelled");
            command.Parameters.AddWithValue("@var4", Session["username"].ToString());
            command.Parameters.AddWithValue("@var5", Convert.ToInt32(Label9.Text));
  
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

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserHomePage.aspx");
    }
}
