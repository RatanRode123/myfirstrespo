using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class addservengg : System.Web.UI.Page
{
    dbcls obj = new dbcls();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    string gender;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RadioButton1.Checked)
        {
            gender ="male";
           
        }
        else
        {
            gender="female";
        }
        string query = "insert into tblservicemen values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + gender + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
        int i;
        i = obj.InsUpdDel(query);
        string query1 = "insert into tbllogin values('" + TextBox1.Text + "','" + TextBox3.Text + "','servicemen')";
        obj.InsUpdDel(query1);
        Label10.Text =i+ "record inserted";

    }
}
