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

public partial class login : System.Web.UI.Page
{
    dbcls obj = new dbcls();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "select * from tbllogin where userid='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' and type='" + DropDownList1.Text + "'";
        DataSet ds = new DataSet();
        ds = obj.Exeselect(query);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (DropDownList1.Text == "user")
            {
                Session["name"] = TextBox1.Text;
                Response.Redirect("userprofile.aspx");
            }
            else if (DropDownList1.Text == "admin")
            {
                Session["name"] = TextBox1.Text;
                Response.Redirect("adminprofile.aspx");

            }
            else if (DropDownList1.Text == "servicemen")
            {
                Session["name"] = TextBox1.Text;
                Response.Redirect("serviceenggprofile.aspx");
            }
        }
        else
        {
            Response.Write("invalid id/password");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("registration.aspx");
    }
}
