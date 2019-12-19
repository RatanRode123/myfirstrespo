using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs pe)  
	    {
            Font fnt = new Font("Algerian", 30);
            Font fnt1 = new Font("Times New Roman", 20);
            Font fnt2 = new Font("Times New Roman", 20);
	        Graphics g = pe.Graphics;
            g.DrawString("Billing System", fnt, new SolidBrush(Color.Aqua), 520, 100);
	        g.DrawString("Student Name : Rahul D. Varal", fnt1, new SolidBrush(Color.BlueViolet), 500,200);
            g.DrawString("Class : M.sc(C.S.)-1", fnt2, new SolidBrush(Color.Red), 500, 250);
            
	   }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login tr = new Login();
            this.Hide();
            tr.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login tr = new Login();
            this.Hide();
            tr.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }

        

      

    }
}
