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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
         
        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
            cnn.Open();
            string uname = Login.username;
            SqlDataAdapter cmd1 = new SqlDataAdapter();
            cmd1 = new SqlDataAdapter("select pname, price  from reg,product where reg.rid=product.rid and username='"+uname+"'", cnn);
            

            DataTable dt = new DataTable();
            cmd1.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = item["pname"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();


            }
            
    
        }

        private void Panel_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
            cnn.Open();
            string uname = Login.username;
            cmd = new SqlCommand("select shopname  from reg where username=@username", cnn);
            cmd.Parameters.AddWithValue("@username", uname);
            cmd.ExecuteNonQuery();


            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                label1.Text = (read["shopname"].ToString());
            }

            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand();

            int sum=0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                   
                    sum += int.Parse(item.Cells[2].Value.ToString());
                    
                }


            }
            label7.Text = "Total Bill is : " + sum;
           
             
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand();
            SqlCommand cmd4 = new SqlCommand();

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
            cnn.Open();
            string uname = Login.username;
            int id;
            cmd4 = new SqlCommand("select rid from reg where username=@username", cnn);
            cmd4.Parameters.AddWithValue("@username", uname);
            cmd4.ExecuteNonQuery();
            SqlDataReader read = cmd4.ExecuteReader();
            read.Read();
            id= int.Parse((read["rid"].ToString()));
            
            cmd3 = new SqlCommand("insert into product" + "(rid,pname,price)values(@rid,@pname,@price)", cnn);
            cmd3.Parameters.AddWithValue("@rid", id);
            cmd3.Parameters.AddWithValue("@pname", richTextBox1.Text);
            cmd3.Parameters.AddWithValue("@price", richTextBox2.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Product Added Successfully","Message");
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
            cnn.Open();



            DialogResult dr = MessageBox.Show("Are you sure to delete Product?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cmd5 = new SqlCommand("delete from product where pname=@pname", cnn);
                cmd5.Parameters.AddWithValue("@pname", richTextBox3.Text);
                cmd5.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully");
                cnn.Close();

            }
            else if (DialogResult == DialogResult.No)
            {
                //Nothing to do
            }
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

       
       
    }
}
