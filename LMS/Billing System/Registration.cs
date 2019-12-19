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
    public partial class Registration : Form
    {


        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            
                SqlCommand cmd = new SqlCommand();
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
                cnn.Open();



            if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox4.Text == "" || richTextBox5.Text == "" )
            {
                
                MessageBox.Show("Please fill in all fields", "Error");
             }
             
            
                SqlCommand cmd1 = new SqlCommand("select * from reg where username=@username", cnn);
                cmd1.Parameters.AddWithValue("@username", richTextBox2.Text);
                cmd1.ExecuteNonQuery();
                SqlDataReader rd = cmd1.ExecuteReader();
               
             if (rd.HasRows)
              {
                    MessageBox.Show("Username Already Exit!","Error");
              }
            

             else if (!Regex.Match(richTextBox1.Text, "^[a-zA-Z\\s]*$").Success || !Regex.Match(richTextBox2.Text, "[A-Za-z][A-Za-z0-9._]{5,14}").Success || !Regex.Match(richTextBox4.Text, "[A-Za-z][A-Za-z0-9._]{5,14}").Success || !Regex.Match(richTextBox5.Text, "[A-Z]*[a-z]*").Success)
            {

                MessageBox.Show("Plz Enter Valid Data", "Error");

            }
            else if(richTextBox3.Text !=richTextBox4.Text )
            {
                MessageBox.Show("Enter Same Password", "Error");
            }

            else
            {
                

                cmd = new SqlCommand("insert into reg" + "(name,username,password,shopname)values(@name,@username,@password,@shopname)", cnn);
                cmd.Parameters.AddWithValue("@name", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@username", richTextBox2.Text);
                cmd.Parameters.AddWithValue("@password", richTextBox4.Text);
                cmd.Parameters.AddWithValue("@shopname", richTextBox5.Text);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Registration Successful");

                cnn.Close();

                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
        

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            label1.Show();
        }

    }
}
