<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownloadFiles.aspx.cs" Inherits="CalenderWebFormASP.DownloadFiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Demo of Download at server side</h3>
        <div>
            <p>
                Click the Button to Download Image and file.
            </p>
            <asp:Button runat="server" ID="button1" Text="Click to Download file" OnClick="button1_Click"/><br /><br />
            <asp:Button runat="server" ID="button2" Text="Click to Download Image" OnClick="button2_Click" />
        </div>
    </form>
    <p>
        <asp:Label ID="Label1" runat="server" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" />
    </p>
</body>
</html>
