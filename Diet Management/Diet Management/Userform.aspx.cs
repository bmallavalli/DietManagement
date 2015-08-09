using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Diet_Management
{
    public partial class Userform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["uname"].ToString();
            Label1.Font.Size = FontUnit.Large;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Button1.BackColor = Color.Maroon;
            Button2.BackColor = Color.Maroon;

            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label1.Text + "'", con);

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
            Label1.Text = "Welcome " + Session["uname"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bmi.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bmr.aspx");
        }
    }
}