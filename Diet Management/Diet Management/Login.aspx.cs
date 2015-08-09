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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["uname"] = TextBox1.Text;
            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();
            Label1.Font.Size = FontUnit.Large;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            TextBox1.Font.Size = FontUnit.Medium;
            TextBox2.Font.Size = FontUnit.Medium;
            RegularExpressionValidator1.Font.Size = FontUnit.Medium;
            RegularExpressionValidator2.Font.Size = FontUnit.Medium;
            RequiredFieldValidator1.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator2.Font.Size = FontUnit.XXLarge;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from DMUser where User_Name='" + TextBox1.Text + "'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (TextBox2.Text == dr[2].ToString())
                {
                    Response.Redirect("Userform.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Invalid user/password";
                }

            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid user/password";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}