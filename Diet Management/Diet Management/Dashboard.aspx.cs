using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Diet_Management
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

            Label9.Text = Session["uname"].ToString();
            Label9.Font.Size = FontUnit.Large;
            Label2.Font.Size = FontUnit.XLarge;
            Label3.Font.Size = FontUnit.Large;
            Label4.Font.Size = FontUnit.Large;
            Label5.Font.Size = FontUnit.Large;
            Label6.Font.Size = FontUnit.Large;
            Label7.Font.Size = FontUnit.Large;
            Label8.Font.Size = FontUnit.Large;
            Label10.Font.Size = FontUnit.Large;

            RequiredFieldValidator4.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator5.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator6.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator7.Font.Size = FontUnit.XXLarge;


            RadioButtonList1.Font.Size = FontUnit.Large;
            CheckBoxList1.Font.Size = FontUnit.Large;
            CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal;
            DropDownList1.Font.Size = FontUnit.Large;


            if (RadioButtonList1.Text == " No")
            {
                Label4.Visible = false;
                CheckBoxList1.Visible = false;


                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Fruit'", con);
                con.Open();
                SqlDataReader dm1 = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm1;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Vegetable'", con);
                con.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr1;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Diary'", con);
                con.Open();
                SqlDataReader dt1 = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt1;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Protein'", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please 2 select proteins", ""));
                con.Close();
            }

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label9.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            con.Close();
            Label9.Text = "Hey " + Session["uname"].ToString();

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.Text == "Yes")
            {
                Label4.Visible = true;
                CheckBoxList1.Visible = true;
            }

            if (RadioButtonList1.Text == " No")
            {
                Label4.Visible = false;
                CheckBoxList1.Visible = false;


                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Fruit'", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Vegetable'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Diary'", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Protein'", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please 2 select proteins", ""));
                con.Close();
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] disease = new String[3];
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    disease[i] = CheckBoxList1.Items[i].Value;
                }
            }



            if (disease[0] == "Diabetes")
            {
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=1", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.DataSource = dm;
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=2", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.DataSource = dr;
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=4", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.DataSource = dt;
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=3", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.DataSource = ds;
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();

            }

            if (disease[1] == "Heart Disease")
            {

                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "'))) AND FC.Category_Id=1", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.DataSource = dm;
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();


                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "'))) AND FC.Category_Id=2", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.DataSource = dr;
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();
                con.Close();



                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "'))) AND FC.Category_Id=4", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.DataSource = dt;
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "'))) AND FC.Category_Id=3", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.DataSource = ds;
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();


                con.Close();
            }

            if (disease[2] == "HighBP")
            {

                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=1", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.DataSource = dm;
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();
                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));

                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=2", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.DataSource = dr;
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();
                con.Close();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=4", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.DataSource = dt;
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=3", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.DataSource = ds;
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();
            }

            if (disease[0] == "Diabetes" & disease[1] == "Heart Disease")
            {

                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')))" +
                                     " AND C.Category_Id=1;", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')))" +
                                     " AND C.Category_Id=2;", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')))" +
                                     " AND C.Category_Id=4;", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = ds;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')))" +
                                     " AND C.Category_Id=3;", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = dt;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();
            }

            if (disease[0] == "Diabetes" & disease[2] == "HighBP")
            {
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();

                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=1;", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=2;", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=4;", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=3;", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();
            }

            if (disease[1] == "Heart Disease" & disease[2] == "HighBP")
            {
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=1;", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=2;", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=4;", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMHeartDisease D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHighBP H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=3;", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();
            }


            if (disease[0] == "Diabetes" & disease[1] == "Heart Disease" & disease[2] == "HighBP")
            {
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR" +
                                     " (FC.Food_Id" +
                                     " IN (Select HBP.Food_Id from DMHighBP HBP inner join DMDisease M ON M.Disease_Id=HBP.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=1;", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataSource = dm;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                ListBox1.Items.Insert(0, new ListItem("Please select 2 fruits", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR" +
                                     " (FC.Food_Id" +
                                     " IN (Select HBP.Food_Id from DMHighBP HBP inner join DMDisease M ON M.Disease_Id=HBP.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=2;", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                ListBox2.Items.Insert(0, new ListItem("Please select 4 vegetables", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR" +
                                     " (FC.Food_Id" +
                                     " IN (Select HBP.Food_Id from DMHighBP HBP inner join DMDisease M ON M.Disease_Id=HBP.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=4;", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select 2 diary products", ""));
                con.Close();
                cmd = new SqlCommand("Select Distinct FC.Food_Id, FC.Food_Name from DMFoodCalorie FC join DMFoodCategory C on FC.Category_Id=C.Category_Id where ((FC.Food_Id" +
                                     " IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "')) OR (FC.Food_Id" +
                                     " IN (Select H.Food_Id from DMHeartDisease H inner join DMDisease M ON M.Disease_Id=H.Disease_Id where M.Disease_Name='" + disease[1] + "')) OR" +
                                     " (FC.Food_Id" +
                                     " IN (Select HBP.Food_Id from DMHighBP HBP inner join DMDisease M ON M.Disease_Id=HBP.Disease_Id where M.Disease_Name='" + disease[2] + "')))" +
                                     " AND C.Category_Id=3;", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select 2 proteins", ""));
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int checkselected = 0;

            String[] fruit = new string[5];
            String[] vegetable = new string[10];
            String[] diary = new string[5];
            String[] protein = new string[5];

            Chart1.Visible = true;
            double fruit1cal = 0;
            double fruit2cal = 0;
            double vegetable1cal = 0;
            double vegetable2cal = 0;
            double vegetable3cal = 0;
            double vegetable4cal = 0;
            double diary1cal = 0;
            double diary2cal = 0;
            double protein1cal = 0;
            double protein2cal = 0;
            double bmr = 0;

            int i = 0;
            int j = 0;
            int k = 1;
            int l = 1;

            foreach (ListItem li in ListBox1.Items)
            {

                if (li.Selected == true)
                {
                    fruit[i] = li.Text;
                    i++;
                }
            }

            if (i != 2)
            {
                checkselected = 2;
                Label6.Visible = true;

            }

            if (i == 2)
            {
                if (DropDownList1.Text == "Select Calories")
                {
                    Label10.Visible = true;
                }

                if (DropDownList1.Text != "Select Calories")
                {
                    bmr = Convert.ToDouble(DropDownList1.Text);
                    bmr = bmr / 10;

                    if (fruit[0] != "Please select 2 fruits" & fruit[1] != "Please select 2 fruits")
                    {
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + fruit[0] + "'", con);
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            fruit1cal = Convert.ToDouble(dr[0]);
                        }
                        con.Close();
                        fruit1cal = fruit1cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + fruit[1] + "'", con);
                        SqlDataReader dt;
                        con.Open();
                        dt = cmd.ExecuteReader();
                        if (dt.Read() == true)
                        {
                            fruit2cal = Convert.ToDouble(dt[0]);
                        }
                        con.Close();
                        fruit2cal = fruit2cal * bmr;
                    }

                    checkselected = 1;
                    Label6.Visible = false;
                }

            }


            foreach (ListItem li in ListBox2.Items)
            {

                if (li.Selected == true)
                {
                    fruit[j] = li.Text;
                    j++;
                }
            }

            if (j != 4)
            {
                checkselected = 2;
                Label5.Visible = true;

            }


            if (j == 4)
            {
                if (DropDownList1.Text == "Select Calories")
                {
                    Label10.Visible = true;
                }

                if (DropDownList1.Text != "Select Calories")
                {
                    bmr = Convert.ToDouble(DropDownList1.Text);
                    bmr = bmr / 10;

                    if (vegetable[0] != "Please select 4 vegetables" & vegetable[1] != "Please select 4 vegetables" & vegetable[2] != "Please select 4 vegetables" & vegetable[3] != "Please select 4 vegetables")
                    {
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + vegetable[0] + "'", con);
                        SqlDataReader dr1;
                        con.Open();
                        dr1 = cmd.ExecuteReader();
                        if (dr1.Read() == true)
                        {
                            vegetable1cal = Convert.ToDouble(dr1[0]);
                        }
                        con.Close();
                        vegetable1cal = vegetable1cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + vegetable[1] + "'", con);
                        SqlDataReader dt1;
                        con.Open();
                        dt1 = cmd.ExecuteReader();
                        if (dt1.Read() == true)
                        {
                            vegetable2cal = Convert.ToDouble(dt1[0]);
                        }
                        con.Close();
                        vegetable2cal = vegetable2cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + vegetable[2] + "'", con);
                        SqlDataReader ds;
                        con.Open();
                        ds = cmd.ExecuteReader();
                        if (ds.Read() == true)
                        {
                            vegetable3cal = Convert.ToDouble(ds[0]);
                        }
                        con.Close();
                        vegetable3cal = vegetable3cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + vegetable[3] + "'", con);
                        SqlDataReader dl;
                        con.Open();
                        dl = cmd.ExecuteReader();
                        if (dl.Read() == true)
                        {
                            vegetable4cal = Convert.ToDouble(dl[0]);
                        }
                        con.Close();
                        vegetable4cal = vegetable4cal * bmr;
                    }

                    checkselected = 1;
                    Label5.Visible = false;
                }

            }



            foreach (ListItem li in ListBox3.Items)
            {

                if (li.Selected == true)
                {
                    diary[k] = li.Text;
                    k++;
                }
            }
            if (k != 3)
            {
                checkselected = 2;
                Label7.Visible = true;
            }


            if (k == 3)
            {
                if (DropDownList1.Text == "Select Calories")
                {
                    Label10.Visible = true;
                }

                if (DropDownList1.Text != "Select Calories")
                {
                    bmr = Convert.ToDouble(DropDownList1.Text);
                    bmr = bmr / 10;

                    if (diary[1] != "Please select 2 diary products" & diary[2] != "Please select 2 diary products")
                    {
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + diary[1] + "'", con);
                        SqlDataReader dr2;
                        con.Open();
                        dr2 = cmd.ExecuteReader();
                        if (dr2.Read() == true)
                        {
                            diary1cal = Convert.ToDouble(dr2[0]);
                        }
                        con.Close();
                        diary1cal = diary1cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + diary[2] + "'", con);
                        SqlDataReader dt2;
                        con.Open();
                        dt2 = cmd.ExecuteReader();
                        if (dt2.Read() == true)
                        {
                            diary2cal = Convert.ToDouble(dt2[0]);
                        }
                        con.Close();
                        diary2cal = diary2cal * bmr;
                    }

                    checkselected = 1;
                    Label7.Visible = false;
                }

            }

            foreach (ListItem li in ListBox4.Items)
            {

                if (li.Selected == true)
                {
                    diary[l] = li.Text;
                    l++;
                }
            }
            if (l != 3)
            {
                checkselected = 2;
                Label8.Visible = true;
            }


            if (l == 3)
            {
                if (DropDownList1.Text == "Select Calories")
                {
                    Label10.Visible = true;
                }

                if (DropDownList1.Text != "Select Calories")
                {
                    bmr = Convert.ToDouble(DropDownList1.Text);
                    bmr = bmr / 10;

                    if (protein[1] != "Please select 2 proteins" & protein[2] != "Please select 2 proteins")
                    {
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + protein[1] + "'", con);
                        SqlDataReader dr3;
                        con.Open();
                        dr3 = cmd.ExecuteReader();
                        if (dr3.Read() == true)
                        {
                            protein1cal = Convert.ToDouble(dr3[0]);
                        }
                        con.Close();
                        protein1cal = protein1cal * bmr;
                        cmd = new SqlCommand("Select Food_Quantity from DMFoodCalorie where Food_Name = '" + protein[2] + "'", con);
                        SqlDataReader dt4;
                        con.Open();
                        dt4 = cmd.ExecuteReader();
                        if (dt4.Read() == true)
                        {
                            protein2cal = Convert.ToDouble(dt4[0]);
                        }
                        con.Close();
                        protein2cal = protein2cal * bmr;
                    }

                    checkselected = 1;
                    Label8.Visible = false;
                }

                if (checkselected == 1)
                {
                    Button1.Visible = true;

                }
            }


            

            string[] x = {fruit[0], fruit[1], vegetable[0], vegetable[1], vegetable[2], vegetable[3], diary[1], diary[2], protein[1], protein[2]};
            double[] y = {fruit1cal, fruit2cal, vegetable1cal, vegetable2cal, vegetable3cal, vegetable4cal, diary1cal, diary2cal, protein1cal, protein2cal};
            
           


            
            Chart1.Series["Default"].Points.DataBindXY(x, y);
            Chart1.Series[0].IsValueShownAsLabel = true;
            Chart1.Series[0].Label = "#PERCENT";
            Chart1.Series[0].LegendText = "#AXISLABEL";
            Chart1.Series[0]["PieLabelStyle"] = "Outside";
            Chart1.Legends[0].Enabled = true;

            //Chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            //Chart1.Series["Default"].Points[0].Color = Color.BurlyWood;
            //Chart1.Series["Default"].Points[1].Color = Color.Lavender;
            //Chart1.Series["Default"].Points[2].Color = Color.LawnGreen;

            //Chart1.Series["Default"].ChartType = SeriesChartType.Pie;

            //Chart1.Series["Default"]["PieLabelStyle"] = "Disabled";

            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        }
    }
}