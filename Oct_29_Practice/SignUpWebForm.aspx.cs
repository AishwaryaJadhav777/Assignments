using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace RapidApplicationDesign
{
    public partial class Singup : System.Web.UI.Page
    {
        private string gender;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["TableConnectionString"].ConnectionString);
            connect.Open();
            string InsertQuery = "Insert into RegisteratinTable (Id,Name,Email,Password,Gender,City) values(@Id,@Name,@Email,@Password,@Gender,@City)";
            SqlCommand cmd = new SqlCommand(InsertQuery, connect);

            if (RadioButton1.Checked)
                gender = "Male";
            else if(RadioButton2.Checked)
                gender = "Female";


            cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@City", DropDownList1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            Response.Write("Thank You!!!! Your details are Submitted");
            connect.Close();
            Response.Redirect("Admin1.aspx");
        }
    }
}