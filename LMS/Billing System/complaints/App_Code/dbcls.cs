using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dbcls
/// </summary>
public class dbcls
{
	public dbcls()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    SqlConnection con = new SqlConnection("user id=sa;password=123;database=ccs;Data Source=DESKTOP-C3BUFVQ\\SQLEXPRESS");
    SqlCommand cmd;
    SqlDataAdapter da;
    public int InsUpdDel(string query)
    {
        cmd = new SqlCommand(query, con);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        int i;
    i=cmd.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        return i;
    }
    public DataSet Exeselect(string query)
    {
        da = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "asd");
        return ds;
    }
}
