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

public partial class userfeedback : System.Web.UI.Page
{
    dbcls obj = new dbcls();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["name"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "insert into tblufeedback values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
        int i;
       i= obj.InsUpdDel(query);
       Response.Write(i + "records inserted");
    }
}
