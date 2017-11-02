using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BillinDetailsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "hello " + (string)Session["username"];
        }
        DataSet ds = new DataSet();
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
        try
        {
            con1.Open();
            SqlCommand command = new SqlCommand("SELECT P_Name, Status, Start_date, End_date, Pause_start, Pause_end, Monthly_Rate from Subscription WHERE Username =@var1 ; ", con1);
            command.Parameters.AddWithValue("@var1", Session["username"].ToString());
            
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(ds, "Subscriptions");

        }

        catch (Exception ex)
        {
            ErrorLabel.Text = ex.ToString();
        }
        finally
        {
            con1.Close();
            //Response.Redirect("UserHomePage.aspx");
        }

        DataTable newTable = createDataTableTemplate();

        foreach (DataRow row in ds.Tables["Subscriptions"].Rows)
        {

            DataRow newRow = newTable.NewRow();

            newRow["P_Name"] = row["P_Name"].ToString();
            //newRow["Status"] = row["Status"].ToString();
            newRow["Start_date"] = row["Start_date"].ToString();
            newRow["End_date"] = row["End_date"].ToString();
            newRow["Pause_start"] = row["Pause_start"].ToString();
            newRow["Pause_end"] = row["Pause_end"].ToString();

            double monthlyrate = Convert.ToDouble(row["Monthly_Rate"]);

            DateTime startdate = (Convert.ToDateTime(row["Start_date"].ToString()));
            DateTime enddate = Convert.ToDateTime(row["End_date"].ToString());
            //ErrorLabel.Text = (startdate.ToString() + enddate.ToString());
            double numberofdays = (enddate - startdate).TotalDays;
            double bill = (monthlyrate / 30 ) * numberofdays;
            newRow["Amount_Incurred"] = bill.ToString();


            newTable.Rows.Add(newRow);
        }
        GridView1.DataSource = newTable;
        GridView1.DataBind();

        con1.Close();

    }
    private DataTable createDataTableTemplate()
    {
        DataTable table = new DataTable("Billing Details");

        DataColumn col1 = new DataColumn("P_Name");
        col1.DataType = System.Type.GetType("System.String");

        DataColumn col2 = new DataColumn("Status");
        col2.DataType = System.Type.GetType("System.String");

        DataColumn col3 = new DataColumn("Start_date");
        col2.DataType = System.Type.GetType("System.String");

        DataColumn col4 = new DataColumn("End_date");
        col2.DataType = System.Type.GetType("System.String");

        DataColumn col5 = new DataColumn("Pause_start");
        col2.DataType = System.Type.GetType("System.String");

        DataColumn col6 = new DataColumn("Pause_end");
        col2.DataType = System.Type.GetType("System.String");

        DataColumn col7 = new DataColumn("Amount_Incurred");
        col2.DataType = System.Type.GetType("System.Double");

        table.Columns.Add(col1);
        table.Columns.Add(col2);
        table.Columns.Add(col3);
        table.Columns.Add(col4);
        table.Columns.Add(col5);
        table.Columns.Add(col6);
        table.Columns.Add(col7);
        return table;
    }
}