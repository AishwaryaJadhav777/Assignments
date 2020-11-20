<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryState.aspx.cs" Inherits="QueryStrings.QueryState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 175px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 
           
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">UserName</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <td colspan="2">
                <asp:Label ID="lbstatus" runat="server" />
            </td>
        </table>
    </form>
</body>
</html>
