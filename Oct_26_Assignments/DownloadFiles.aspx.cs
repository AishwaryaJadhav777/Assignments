using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalenderWebFormASP
{
    public partial class DownloadFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            string filepath= "C:\\Users\\PAWAR\\Desktop\\pgms\\WindowsForm.txt";
            FileInfo file = new FileInfo(filepath);
            if(file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content Disposition", "Attachment,filename=" + file.Name);
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.ContentType = "txt/plain";
                Response.Flush();
                Response.TransmitFile(file.FullName);
                Response.End();

            }
            else
            {
                Label1.Text = "Requested file is not available to download";
            }
        }

        protected void button2_Click(object sender, EventArgs e)
        {

            string filepath1 = "C:\\Users\\PAWAR\\Desktop\\pgms\\dog.jpg";
            FileInfo file1 = new FileInfo(filepath1);
            if (file1.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content Disposition", "Attachment,filename=" + file1.Name);
                Response.AddHeader("Content-Length", file1.Length.ToString());
                Response.ContentType = "jpg";
                Response.Flush();
                Response.TransmitFile(file1.FullName);
                Response.End();

            }
            else
            {
                Label2.Text = "Requested Image is not available to download";
            }

        }
    }
}