using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadioButtonExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        string str = "This is ASP.Net Framework webform";
        Response.Write(str);

    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is ASP.Net Webform");
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is ASP.Net Webform");
    }
}