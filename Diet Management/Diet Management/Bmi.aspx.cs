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
    public partial class Bmi : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = Session["uname"].ToString();
            Label1.Font.Size = FontUnit.XLarge;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Label4.Font.Size = FontUnit.Large;
            Label5.Font.Size = FontUnit.Large;
            Label6.Font.Size = FontUnit.Large;
            Label7.Font.Size = FontUnit.Large;
            Label8.Font.Size = FontUnit.Large;

            TextBox4.Font.Size = FontUnit.Medium;
            TextBox2.Font.Size = FontUnit.Medium;
            TextBox3.Font.Size = FontUnit.Medium;

            RegularExpressionValidator1.Font.Size = FontUnit.Medium;
            RegularExpressionValidator3.Font.Size = FontUnit.Medium;
            RegularExpressionValidator2.Font.Size = FontUnit.Medium;
            RequiredFieldValidator1.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator2.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator3.Font.Size = FontUnit.XXLarge;
            
            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label4.Text + "'", con);

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
            Label4.Text = "Hey " + Session["uname"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Double inches = 0;
            Double feet2inch = 0;
            Double weight = 0;
            Double height = 0;
            Double bmi = 0;
            
            
            feet2inch = (Convert.ToDouble(TextBox2.Text)) * 12;
            inches = (Convert.ToDouble(TextBox4.Text)) + feet2inch;
            weight = (Convert.ToDouble(TextBox3.Text));
            height = inches * inches;
            bmi = (weight / height) * 703;





            Label8.Visible = true;
            Label8.Text = "Bmi is:" + string.Format("{0:0.##}", bmi);
            //Response.Write("feet2inch: " + feet2inch + "inches: " + inches + "weight: " + weight + "height: " + height + "bmi: " + bmi);

            if (bmi < 18.5)
            {
                Label7.Visible = true;
                Label7.Text = "Your Bmi category is Under Weight";
            }
            else if ((bmi >= 18.5) && (bmi <= 24.9))
            {
                Label7.Visible = true;
                Label7.Text = "Your Bmi category is Balanced Weight";
            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Your Bmi category is Over Weight";
            }

            Label7.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userform.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("bmr.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}