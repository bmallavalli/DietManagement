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
    public partial class Food : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Diet_Management");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label14.Text = Session["uname"].ToString();
            Label2.Font.Size = FontUnit.Large;
            Label3.Font.Size = FontUnit.Large;
            Label14.Font.Size = FontUnit.Large;
           
            Label5.Font.Size = FontUnit.Large;
            Label6.Font.Size = FontUnit.Large;
            Label7.Font.Size = FontUnit.Large;
            Label8.Font.Size = FontUnit.Large;
            Label9.Font.Size = FontUnit.Large;

            Button4.Font.Size = FontUnit.Large;

            Label10.Font.Size = FontUnit.Medium;
            Label11.Font.Size = FontUnit.Medium;
            Label12.Font.Size = FontUnit.Medium;
            Label13.Font.Size = FontUnit.Medium;

            RadioButtonList1.Font.Size = FontUnit.Large;
            CheckBoxList1.Font.Size = FontUnit.Large;
            CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal;
           // RadioButtonList1.RepeatDirection = RepeatDirection.Horizontal;
            //DropDownList1.Font.Size = FontUnit.Large;

            RequiredFieldValidator1.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator3.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator4.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator5.Font.Size = FontUnit.XXLarge;
            RequiredFieldValidator6.Font.Size = FontUnit.XXLarge;

            Response.Expires = -1;
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.CacheControl = "no-cache";
            Response.Cache.SetNoStore();

            cmd = new SqlCommand("select * from DMUser where User_Name= '" + Label14.Text + "'", con);

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
            Label14.Text = "Hey " + Session["uname"].ToString();

            Label6.Text = "Do you have any disease?";
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button2.Visible = false;
            Label10.Visible=false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
            if (RadioButtonList1.Text == "Yes")
            {
                Label7.Visible = true;
                CheckBoxList1.Visible = true;
                Button1.Visible = true;
            }
            if (RadioButtonList1.Text == "No")
            {
                Label7.Visible = false;
                CheckBoxList1.Visible = false;
                Button1.Visible = true;

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

                //ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Vegetable'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataSource = dr;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                //ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Diary'", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataSource = dt;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                //ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
                con.Close();

                cmd = new SqlCommand("select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC inner join DMFoodCategory D on FC.Category_Id=D.Category_Id where D.Category_Name='Protein'", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataSource = ds;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                //ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
                con.Close();
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button2.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
            String[] disease = new String[3];
            int i;
            Label2.Visible = false;
            Label3.Visible = false;
            Label5.Visible = false;
            Label8.Visible = false;
            ListBox1.Visible = false;
            ListBox2.Visible = false;
            ListBox3.Visible = false;
            ListBox4.Visible = false;

            for (i = 0; i < CheckBoxList1.Items.Count; i++)
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
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Button2.Visible = false;
                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=1", con);
                con.Open();
                SqlDataReader dm = cmd.ExecuteReader();
                ListBox1.DataSource = dm;
                ListBox1.AppendDataBoundItems = true;
                ListBox1.DataTextField = "Food_Name";
                ListBox1.DataValueField = "Food_Id";
                ListBox1.DataBind();

                //ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=2", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ListBox2.DataSource = dr;
                ListBox2.AppendDataBoundItems = true;
                ListBox2.DataTextField = "Food_Name";
                ListBox2.DataValueField = "Food_Id";
                ListBox2.DataBind();

                //ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=4", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.DataSource = dt;
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                //ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMDiabetes D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[0] + "'))) AND FC.Category_Id=3", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.DataSource = ds;
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                //ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
                con.Close();

            }

            if (disease[1] == "Heart Disease")
            {
                Button2.Visible = false;
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                ListBox4.Items.Clear();
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
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

                ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
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
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Button2.Visible = false;
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

                ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=4", con);
                con.Open();
                SqlDataReader dt = cmd.ExecuteReader();
                ListBox3.DataSource = dt;
                ListBox3.AppendDataBoundItems = true;
                ListBox3.DataTextField = "Food_Name";
                ListBox3.DataValueField = "Food_Id";
                ListBox3.DataBind();

                ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
                con.Close();

                cmd = new SqlCommand("Select FC.Food_Id, FC.Food_Name from DMFoodCalorie FC where ((FC.Food_Id IN (Select D.Food_Id from DMHighBP D inner join DMDisease M ON M.Disease_Id=D.Disease_Id where M.Disease_Name='" + disease[2] + "'))) AND FC.Category_Id=3", con);
                con.Open();
                SqlDataReader ds = cmd.ExecuteReader();
                ListBox4.DataSource = ds;
                ListBox4.AppendDataBoundItems = true;
                ListBox4.DataTextField = "Food_Name";
                ListBox4.DataValueField = "Food_Id";
                ListBox4.DataBind();

                ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
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

                    ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
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

                    ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
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

                    ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
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

                    ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
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

                    ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
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

                    ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
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

                    ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
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

                    ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
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

                    ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
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

                    ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
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

                    ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
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

                    ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
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

                    ListBox1.Items.Insert(0, new ListItem("Please select fruits", ""));
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

                    ListBox2.Items.Insert(0, new ListItem("Please select vegetables", ""));
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

                    ListBox3.Items.Insert(0, new ListItem("Please select diary products", ""));
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

                    ListBox4.Items.Insert(0, new ListItem("Please select proteins", ""));
                    con.Close();
                }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label3.Visible = true;
            Label5.Visible = true;
            Label8.Visible = true;
            ListBox1.Visible = true;
            ListBox2.Visible = true;
            ListBox3.Visible = true;
            ListBox4.Visible = true;
            Button2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label9.Visible = false;
            Label9.Font.Size = FontUnit.XLarge;
            Label9.Text = "";

            

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

            int checkselected = 0;

            String[] fruit = new string[5];
            String[] vegetable = new string[10];
            String[] diary = new string[5];
            String[] protein = new string[5];
            Label9.Text = "";



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

           
            if(i==2)
            {

                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr / 10;
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
                string display = "FRUITS " + "<br />" + fruit[0] + "- " + string.Format("{0:0.##}", fruit1cal) + "ounces;     " + fruit[1] + ": " + string.Format("{0:0.##}", fruit2cal) + "ounces" + "<br />" + "<br />" + "<br />";
                Label9.Text = Label9.Text + display;
                checkselected = 1;
                Label10.Visible = false;

            }

            else
            {
                checkselected = 2;
                Label10.Visible = true;
                
            }

            bmr = 0;
            foreach (ListItem li in ListBox2.Items)
            {

                if (li.Selected == true)
                {
                    vegetable[j] = li.Text;
                    j++;
                }
            }
            if (j == 4)
            {
                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr / 10;
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

                string display1 = "VEGETABLES " + "<br />" + vegetable[0] + "- " + string.Format("{0:0.##}", vegetable1cal) + "ounces;     " + vegetable[1] + "- " + string.Format("{0:0.##}", vegetable2cal) + "ounces;     " + vegetable[2] + "- " + string.Format("{0:0.##}", vegetable3cal) + "ounces;     " + vegetable[3] + "- " + string.Format("{0:0.##}", vegetable4cal) + "ounces" + "<br />" + "<br />" + "<br />";
                Label9.Text = Label9.Text + display1;
                checkselected = 1;
                Label11.Visible = false;
            }

            else
            {
                checkselected = 2;
                Label11.Visible = true;
            }

            bmr = 0;
            foreach (ListItem li in ListBox3.Items)
            {

                if (li.Selected == true)
                {
                    diary[k] = li.Text;
                    k++;
                }
            }

            if (k == 3)
            {
                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr / 10;
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
                string display2 = "DIARY PRODUCTS " + "<br />" + diary[1] + "- " + string.Format("{0:0.##}", diary1cal) + "ounces;     " + diary[2] + ": " + string.Format("{0:0.##}", diary2cal) + "ounces" + "<br />" + "<br />" + "<br />";
                Label9.Text = Label9.Text + display2;
                checkselected = 1;
                Label12.Visible = false;
            }
            else
            {
                checkselected = 2;
                Label12.Visible = true;
            }

            bmr = 0;
            foreach (ListItem li in ListBox4.Items)
            {

                if (li.Selected == true)
                {
                    protein[l] = li.Text;
                    l++;
                }
            }

            if (l == 3)
            {
                bmr = Convert.ToDouble(Session["bmrval"]);
                bmr = bmr / 10;
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
                string display4 = "PROTEINS " + "<br />" + protein[1] + "- " + string.Format("{0:0.##}", protein1cal) + "ounces;     " + protein[2] + "- " + string.Format("{0:0.##}", protein2cal) + "ounces" + "<br />" + "<br />" + "<br />";
                Label9.Text = Label9.Text + display4;
                Session["result"] = Label9.Text;
                checkselected = 1;
                Label10.Visible = false;
                Label13.Visible = false;
            }
            else
            {
                checkselected = 2;
                Label13.Visible = true;
            }

            if (checkselected == 1)
            {
                Button4.Visible = true;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("bmr.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Result.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

          
    }
}