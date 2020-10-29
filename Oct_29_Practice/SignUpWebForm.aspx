<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Singup.aspx.cs" Inherits="RapidApplicationDesign.Singup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
            width: 508px;
            margin-bottom: 96px;
        }
        .auto-style2 {
            width: 326px;
            height: 34px;
        }
        .auto-style3 {
            height: 34px;
        }
        .auto-style4 {
            width: 326px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            width: 326px;
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
        }
        .auto-style8 {
            height: 29px;
            width: 508px;
            margin-bottom: 96px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style8">
        <table style="width: 124%; height: 135px;">
            <tr>
                <td class="auto-style1">Id</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" BackColor="#3399FF" Width="205px" TextMode="Email"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" BackColor="#3399FF" Width="205px" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Confirm Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" BackColor="#3399FF" Width="205px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style6">Gender</td>
                <td class="auto-style7">
                    <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" Text="Male" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#33CC33" Text="Female" />
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style6">City</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="122px">
                        <asp:ListItem>Please Select</asp:ListItem>
                        <asp:ListItem>Bangalore</asp:ListItem>
                        <asp:ListItem>Mubmai</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Ahamdabad</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Solapur</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="103px" />
                </td>
            </tr>
        </table>
        </form>
</body>
</html>
