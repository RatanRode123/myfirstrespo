using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Register : System.Web.UI.Page
{


    SqlCommand cmd = new SqlCommand();
    SqlConnection cnn = new SqlConnection();


    protected void Page_Load(object sender, EventArgs e)
    {

        cnn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\LMS\App_Data\LMS.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True";
        cnn.Open();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlCommand cmd1 = new SqlCommand("select * from reg where username=@username", cnn);
        cmd1.Parameters.AddWithValue("@username", TextBox2.Text);
        cmd1.ExecuteNonQuery();
        SqlDataReader rd = cmd1.ExecuteReader();
        if (rd.HasRows)
        {
            Label1.Text = "Username Already Exit!";
        }
        else
        {
            SqlCommand cmd = new SqlCommand("insert into reg" + "(name,username,password,email,dob,gender,address)values(@name,@username,@password,@email,@dob,@gender,@address)", cnn);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@username", TextBox2.Text);
            cmd.Parameters.AddWithValue("@password", TextBox3.Text);
            cmd.Parameters.AddWithValue("@email", TextBox5.Text);
            cmd.Parameters.AddWithValue("@dob", TextBox6.Text);
            cmd.Parameters.AddWithValue("@gender", Gender.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@address", TextBox8.Text);
            // cmd.Parameters.AddWithValue("@ausername", "admin@mcs");


            cmd.ExecuteNonQuery();
            cnn.Close();
            Label1.Text = "Your Registration Successful! ";

        }
    }
}