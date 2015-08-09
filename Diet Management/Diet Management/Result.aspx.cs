using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Diet_Management
{
    public partial class Result : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Session["uname"].ToString();
            Label2.Text = Session["result"].ToString();
            Label1.Font.Size = FontUnit.XLarge;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Button1.Font.Size = FontUnit.Large;

            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label3.Text + "'", con);

            con.Open();
            SqlDataReader dm = cmd.ExecuteReader();
            if (dm.HasRows)
            {
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            con.Close();
            Label3.Text = "Hey " + Session["uname"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Food.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}