﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["username"] = null;

        }
    }

    protected void Submit1_ServerClick(object sender, EventArgs e)
    {
        string user_name = text_Username.Value;
        string pswd = text_Password.Value;
        string user_type = RadioButtonList1.SelectedValue;

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("select Username,Password,User_type from Users where Username=@var1 and Password=@var2 and User_type=@var3", con1);
            command.Parameters.AddWithValue("@var1",user_name);
            command.Parameters.AddWithValue("@var2", pswd);
            command.Parameters.AddWithValue("@var3", user_type);
            /*SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "user_details");
            con1.Close();*/
            SqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.HasRows == false)
            {
                Error_Label.Text = "Invalid Credentials";
            }
            else
            {
                reader.Read();
                if (user_type.Equals("Subscriber"))
                {
                    Session["username"] = reader["Username"].ToString();
                    con1 = new SqlConnection();
                    con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
                    try
                    {
                        con1.Open();
                        command = new SqlCommand("select Region, Pincode from Users where Username=@var1", con1);
                        command.Parameters.AddWithValue("@var1", user_name);
                        reader = command.ExecuteReader();

                        reader.Read();
                        Session["pincode"] = reader["Pincode"].ToString();
                        Session["region"] = reader["Region"].ToString();
                        Response.Redirect("UserHomePage.aspx?");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    Session["username"] = reader["Username"].ToString();
                    Response.Redirect("EmployeeHomePage.aspx");
                }
            }
        }
        catch(Exception ex)
        {
            Error_Label.Text = user_name + "  " + pswd  + "  " + user_type + "  " +  ex.ToString();
        }
        finally
        {
            con1.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }

}