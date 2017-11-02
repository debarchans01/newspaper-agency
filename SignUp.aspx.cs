using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton1_Clicked(object sender, EventArgs e)
    {
        string name = Text1.Value;
        string emailid = Text2.Value;
        string username = Text3.Value;
        string password = Password1.Value;
        string address = Text4.Value;
        string city = Text5.Value;
        string state = Text6.Value;
        string country = Text7.Value;
        string pincode = Text8.Value;

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("insert Users(Name, Email_id, Username, Password, Address, City, Pincode, State, Country,User_type) VALUES(@var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8, @var9, @var10)", con1);
            command.Parameters.AddWithValue("@var1", name);
            command.Parameters.AddWithValue("@var2", emailid);
            command.Parameters.AddWithValue("@var3", username);
            command.Parameters.AddWithValue("@var4", password);
            command.Parameters.AddWithValue("@var5", address);
            command.Parameters.AddWithValue("@var6", city);
            command.Parameters.AddWithValue("@var7", pincode);
            command.Parameters.AddWithValue("@var8", state);
            command.Parameters.AddWithValue("@var9", country);
            command.Parameters.AddWithValue("@var10", DropDownList2.SelectedItem.Text);


            SqlDataReader reader = command.ExecuteReader();

        }
        catch (Exception ex)
        {
            ErrorLabel1.Text = ex.ToString();
        }
        finally
        {
            con1.Close();
            Response.Redirect("StartPage.aspx");
        }
    }

}
