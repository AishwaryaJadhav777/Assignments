using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataBound
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                
                SqlCommand cmd = new SqlCommand("select * from Student", Connect);
                Connect.Open();
                SqlDataAdapter SDE = new SqlDataAdapter(cmd);//To retrive the data from database
                DataSet ds = new DataSet();//to convert the data into the grid.
                SDE.Fill(ds, "Student");
                Rp1.DataSource = ds;
                Rp1.DataBind();
                Connect.Close();

            }


        }
    }
}