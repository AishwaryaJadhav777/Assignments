using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadiobuttonPractice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        genderid.Text = "";
        if (Radiobutton1.Checked)
            genderid.Text = "You are " + Radiobutton1.Text;
        else
            genderid.Text = "You are " + Radiobutton2.Text;
    }
}