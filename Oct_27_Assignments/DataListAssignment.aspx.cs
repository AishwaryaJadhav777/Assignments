using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesASP
{
    public partial class DataListAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Designation");
            table.Columns.Add("Location");
            table.Columns.Add("Country");


            table.Rows.Add( "Aishwarya","Jadhav", "Software Engineer","Solapur","India");
            table.Rows.Add("Asmita", "Jadhav", "HR", "Mumbai", "India");
            table.Rows.Add("Varsha", "Aainure", "Manager", "Pune", "India");
            table.Rows.Add("Aasharani", "Waghmode", "intern", "Hyderbad", "India");
            table.Rows.Add("Manasi", "Wabhuvan", "Software Engineer", "Bangalore", "India");
            table.Rows.Add("Rai", "Patil", "HR", "Solapur", "India");
            table.Rows.Add("Aarti", "Nishandar", "Software Engineer", "Kalkatta", "India");
            table.Rows.Add("Priyanka", "Raikar", "Manager", "Chennai", "India");
            table.Rows.Add("Vaishnavi", "Chdachnakar", "Software Engineer", "Chennai", "India");
            table.Rows.Add("Shivani", "Darekar", "Software Engineer", "Solapur", "India");


            Datalist1.DataSource = table;
            Datalist1.DataBind();

        }
    }
}