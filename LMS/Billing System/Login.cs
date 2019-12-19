using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace Billing_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }



        public static string username = "";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Plz Enter Username and Password ");
            }
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False";
            cnn.Open();

            cmd = new SqlCommand("select username password from reg where username=@username and password=@password", cnn);
            cmd.Parameters.AddWithValue("@username", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@password", richTextBox2.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = richTextBox1.Text;
                Panel p = new Panel();
                this.Hide();
                p.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Login Check Username and Password","Error");
            }  
            
            
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }
        

       



        
        

       
    }
}
