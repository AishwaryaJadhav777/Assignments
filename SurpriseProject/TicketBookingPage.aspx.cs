using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class TicketBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Choose the Flight");
            //Establish the connection to the database
            using (SqlConnection Connect = new SqlConnection("data Source=.; database=Training; integrated security=SSPI"))
            {

                SqlDataAdapter SDE = new SqlDataAdapter("select * from Flight", Connect);//To retrive the data from database
                DataSet ds = new DataSet();//to convert the data into the grid.
                SDE.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }




        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {


            
            string gender = "";
            if (RadioButton1.Checked)
                gender = RadioButton1.Text;
            else
                gender = RadioButton2.Text;

            string Tic = "Your Ticket has been generated:" + "Passenger Name: " + TextBox1.Text +
                "Age: " + TextBox2.Text + "Gender:" + gender + "Flight_ID:" + TextBox3.Text + "Flight Number:" + TextBox4.Text +
                "Flight Name:" + TextBox5.Text + "Source:" + TextBox6.Text + "Destination:" + TextBox7.Text;
            Label1.Text = Tic;
        }

        
    }
}