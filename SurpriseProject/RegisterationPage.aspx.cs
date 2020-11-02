using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string gender;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            connect.Open();
            string InsertQuery = "Insert into Registeration (Id,UserName,Password,Age,Gender) values(@ID,@UserName,@Password,@Age,@Gender)";
            SqlCommand cmd = new SqlCommand(InsertQuery, connect);

            if (RadioButton1.Checked)
                gender = "Male";
            else if (RadioButton2.Checked)
                gender = "Female";

            cmd.Parameters.AddWithValue("@ID", TextBox5.Text);
            cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();
            //Response.Write("Thank You!!!! Your details are Submitted");
            connect.Close();
            Response.Redirect("Admin.aspx");
        }
    }
}