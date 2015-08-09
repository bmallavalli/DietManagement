using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Diet_Management
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        string regno = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int userid = 0;
            Label1.Font.Size = FontUnit.Large;
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Label4.Font.Size = FontUnit.Large;
            TextBox1.Font.Size = FontUnit.Medium;
            TextBox2.Font.Size = FontUnit.Medium;
            TextBox3.Font.Size = FontUnit.Medium;

            RegularExpressionValidator1.Font.Size = FontUnit.Medium;
            RegularExpressionValidator2.Font.Size = FontUnit.Medium;
            RequiredFieldValidator1.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator2.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator3.Font.Size = FontUnit.XXLarge;
            CompareValidator1.Font.Size = FontUnit.Medium;
            cmd = new SqlCommand("select count(*) from DMUser", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                regno = dr[0].ToString();
            }
            con.Close();

            userid = Convert.ToInt32(regno) + 1;
            regno = Convert.ToString(userid);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from DMUser where User_Name='" + TextBox1.Text + "' or Password = '"+TextBox2.Text+"'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
           
            if (dr.Read() == true)
            {
                if (TextBox1.Text == dr[1].ToString())
                {

                    Label1.Visible = true;
                    Label1.Text = "Username already exists try another one";
                }

                if (TextBox2.Text == dr[2].ToString())
                {

                    Label1.Visible = true;
                    Label1.Text = "Password already exists try another one";
                }

            }
           
            

            else
            {
                con.Close();
                cmd = new SqlCommand("insert into DMUser values('"+regno+"','" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "Registered Successfully";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Database Error";
                }
                con.Close(); 
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}
