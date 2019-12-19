using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
public partial class Adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        cnn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\LMS\App_Data\LMS.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True";
        cnn.Open();

        cmd = new SqlCommand("select username password from admin where username=@username and password=@password", cnn);
        cmd.Parameters.AddWithValue("@username", TextBox1.Text);
        cmd.Parameters.AddWithValue("@password", TextBox2.Text);
        cmd.ExecuteNonQuery();

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Response.Redirect("Adminprofile.aspx");
        }
        else
        {
            Label1.Text = "Invalid Login Check Username and Password";
        }

        cnn.Close();
    }
}