<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextBoxPractice.aspx.cs" Inherits="TextBoxPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username" />

            <asp:TextBox ID="Username" runat="server" ToolTip="Enter your name" style="margin-left: 12px" Width="141px"/>

        </div>
        <p>
            <asp:Button ID="button1" runat="server" Text="Submit" OnClick="button1_Click" />
        </p>
    </form>

    <asp:Label ID="userinput" runat="server" />
</body>
</html>
