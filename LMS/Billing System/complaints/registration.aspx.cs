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

public partial class registration : System.Web.UI.Page
{
    dbcls obj = new dbcls();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "insert into tblreg values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
        int i;
        i=obj.InsUpdDel(query);
        string squery = "insert into tbllogin values('" + TextBox1.Text + "','" + TextBox3.Text + "','user')";
        obj.InsUpdDel(squery);
        Label1.Text = i + "record(s) inserted";
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}






