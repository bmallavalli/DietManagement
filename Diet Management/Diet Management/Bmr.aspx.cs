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
    public partial class Bmr : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = Session["uname"].ToString();
            Label1.Font.Size = FontUnit.XLarge;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Label4.Font.Size = FontUnit.Large;
            Label5.Font.Size = FontUnit.Large;
            Label6.Font.Size = FontUnit.Large;
            Label7.Font.Size = FontUnit.Large;
            Label8.Font.Size = FontUnit.Large;
            Label9.Font.Size = FontUnit.Large;
            Label10.Font.Size = FontUnit.Large;
            Label11.Font.Size = FontUnit.Large;
            Label12.Font.Size = FontUnit.Large;

            TextBox1.Font.Size = FontUnit.Medium;
            TextBox2.Font.Size = FontUnit.Medium;
            TextBox3.Font.Size = FontUnit.Medium;
            TextBox4.Font.Size = FontUnit.Medium;

            
            DropDownList1.Font.Size = FontUnit.Large;
            DropDownList2.Font.Size = FontUnit.Large;
            RadioButtonList3.Font.Size = FontUnit.Large;
            RadioButtonList1.Font.Size = FontUnit.Large;
            //RadioButtonList3.RepeatDirection = RepeatDirection.Horizontal;

            RegularExpressionValidator1.Font.Size = FontUnit.Medium;
            RegularExpressionValidator3.Font.Size = FontUnit.Medium;
            RegularExpressionValidator2.Font.Size = FontUnit.Medium;
            RegularExpressionValidator4.Font.Size = FontUnit.Medium;
            RequiredFieldValidator4.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator5.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator6.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator1.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator2.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator3.Font.Size = FontUnit.XXLarge;

            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label5.Text + "'", con);

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
            Label5.Text = "Hey " + Session["uname"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Double height = 0;
            Double feet2inch = 0;
            Double weight = 0;
            Double age = 0;
            Double bmr = 0;



            feet2inch = (Convert.ToDouble(TextBox1.Text)) * 12;
            height = (Convert.ToDouble(TextBox4.Text)) + feet2inch;
            weight = (Convert.ToDouble(TextBox2.Text));
            age = (Convert.ToDouble(TextBox3.Text));
            if (RadioButtonList1.Text == "Female")
            { 
                bmr = 655 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
                if (DropDownList2.Text == "Verylow")
                {
                    bmr = bmr * 1.2;
                }
                else if (DropDownList2.Text == "Lightest")
                {
                    bmr = bmr * 1.375;
                }
                else if (DropDownList2.Text == "Moderate")
                {
                    bmr = bmr * 1.55;
                }
                else if (DropDownList2.Text == "Heaviest")
                {
                    bmr = bmr * 1.725;
                }
                else
                {
                    bmr = bmr * 1.9;
                }
            }
            else
            {
                bmr = 66 + (6.23 * weight) + (12.7 * height) - (6.8 * age);
                if (DropDownList2.Text == "Verylow")
                {
                    bmr = bmr * 1.2;
                }
                else if (DropDownList2.Text == "Lightest")
                {
                    bmr = bmr * 1.375;
                }
                else if (DropDownList2.Text == "Moderate")
                {
                    bmr = bmr * 1.55;
                }
                else if (DropDownList2.Text == "Heaviest")
                {
                    bmr = bmr * 1.725;
                }
                else
                {
                    bmr = bmr * 1.9;
                }
            }

            Label8.Visible = true;
            Label8.Text = "Calories Intake: " + string.Format("{0:0.##}", bmr);
            Session["bmrval"] = bmr;
            Label9.Visible = true;
            Label12.Visible = true;
            RadioButtonList3.Visible = true;
            DropDownList1.Visible = true;
        }

        protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList3.Text == "Yes")
            {
                Response.Redirect("Food.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bmi.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double bmr = 0;
            if (DropDownList1.Text == "Gain")
            {
                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr + 500;
                Label8.Text = "To Gain; Calories Intake Are: " + string.Format("{0:0.##}", bmr);
                Session["bmrval"] = bmr;
                DropDownList1.Visible = false;
                Label12.Visible = false;
            }

            else if (DropDownList1.Text == "Loss")
            {
                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr - 500;
                Label8.Text = "To Loss; Calories Intake Are: " + string.Format("{0:0.##}", bmr);
                Session["bmrval"] = bmr;
                DropDownList1.Visible = false;
                Label12.Visible = false;
            }

            else
            {
                DropDownList1.Visible = false;
                Label12.Visible = false;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}