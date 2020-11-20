using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_and_ControlState
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if ((ViewState["Counter"]) == null)
                count += 1;
            else
                count =((int) ViewState["Counter"])+1;
            ViewState["Counter"] = count;
            Response.Write("Page hit count are : " + count);
        }
    }
}