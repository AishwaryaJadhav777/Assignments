<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBooking.aspx.cs" Inherits="WebApplication1.TicketBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 207px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Passenger Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Flight ID</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Flight Number</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Flight Name</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Source</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Destination</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" Width="63px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
