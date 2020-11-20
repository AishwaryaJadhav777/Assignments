using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStrings
{
    public partial class QueryState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                TextBox1.Focus();//Is used keep the cursor within textbox

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox1.Text == "admin")
            {
                Response.Redirect("HomePage.aspx?Name = " +TextBox1.Text +"&Pwd=" +TextBox2.Text);
                Response.Redirect("Login Successful");
            }

            else
                lbstatus.Text = "Invalid Login Credential, Login failed";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}