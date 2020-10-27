using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalenderWebFormASP
{
    public partial class LinkButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

       
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Facebook";
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Instagram";
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Whatsapp";
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Twitter";
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to Youtube";
        }

        protected void Linkbutton6_Command(object sender, CommandEventArgs e)
        {
            Label1.Text = "Welcome to Coursera";
        }

       
    }
}