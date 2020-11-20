<%@ Page Trace="true" Language="C#" AutoEventWireup="true" CodeBehind="CountDemo.aspx.cs" Inherits="Demo.CountDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="WebCount" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Open Another Webpage" PostBackUrl="~/GetHiddenFieldValues.aspx" />

            <asp:HiddenField ID="hfCount" runat="server" Value="0" />
        </div>
    </form>
</body>
</html>
