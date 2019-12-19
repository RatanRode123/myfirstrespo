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

public partial class servenggcomplaints : System.Web.UI.Page
{
    dbcls obj = new dbcls();
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "select servid,complaint from tblstatus where servid='" + Session["name"].ToString() + "'";
        DataSet ds = new DataSet();
        ds = obj.Exeselect(query);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        int col = row.Cells.Count - 1;
        TextBox3.Text = row.Cells[1].Text;
        TextBox1.Text = row.Cells[2].Text;
        //TextBox2.Text = row.Cells[3].Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "update tblstatus set status='" + TextBox2.Text + "' where servid='" + TextBox3.Text + "'";
        obj.InsUpdDel(query);

    }
}
