using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class CountDemo : System.Web.UI.Page
    {
        int count ;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(hfCount.Value);//Hidden Field is by default string returning specimen.
            count += 1;
            Response.Write("Number of Counts are : " + count);
            hfCount.Value = count.ToString();
        }
    }
}