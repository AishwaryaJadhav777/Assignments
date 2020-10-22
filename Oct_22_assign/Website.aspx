<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPSample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Page of the Web Page Project</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("My first Page created in IIS Express"); %><br />
            <%Response.Write("This is an example of Website Project"); %>
        </div>
        <p>Webforms are the Webpages in ASP.Net</p>
    </form>
</body>
</html>
