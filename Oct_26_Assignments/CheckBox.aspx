<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="CalenderWebFormASP.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select the Course of Programming you want to Learn</h2>
            <asp:CheckBox ID="checkbox1" runat="server" Text="Python Programming" /><br />
            <asp:CheckBox ID="checkbox2" runat="server" Text="Java Programming" /><br />
            <asp:CheckBox ID="checkbox3" runat="server" Text="ASP.Net Web Programming" /><br />
            <asp:CheckBox ID="checkbox4" runat="server" Text="CSharp Programming" /><br />
            <asp:CheckBox ID="checkbox5" runat="server" Text="C Programming" />

        </div>
        <p>
            <asp:Button ID="button1" runat="server" Text="Submit" OnClick="button1_Click" />
        </p>
           <asp:Label runat="server" ID="ShowCources" Text="You are Selected : "/>
        <p>

        </p>
    </form>
</body>
</html>
