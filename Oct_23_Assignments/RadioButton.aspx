<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioButtonExample.aspx.cs" Inherits="RadioButtonExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="Thia is a Example of Radio Button " Font-Bold="True" Font-Size="Larger" ForeColor="Fuchsia"></asp:Label><br /><br />

        </div>
        <div>
            
            <asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" ForeColor="Red" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Red" /><br />
            <asp:RadioButton ID="RadioButton2" runat="server" Font-Bold="True" ForeColor="Blue" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Blue" /><br />
            <asp:RadioButton ID="RadioButton3" runat="server" Font-Bold="True" ForeColor="#00CC00" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Green" />

        </div>
    </form>
</body>
</html>
