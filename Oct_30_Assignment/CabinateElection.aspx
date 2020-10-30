<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Electionaspx.aspx.cs" Inherits="ASPValidations.Electionaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style8 {
            height: 42px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style18 {
            height: 42px;
        }
        .auto-style2 {
            width: 398px;
            height: 50px;
        }
        .auto-style16 {
            height: 50px;
        }
        

        .auto-style1 {
            height: 25px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style19 {
            width: 398px;
            margin-bottom: 96px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table style="width: 124%; height: 135px;">
                <tr>
                    <td class="auto-style8">Candidate</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style19">House</td>
                    <td>
                        <br />
                        <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" Text="Red" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#3333CC" Text="Blue" />
                        <br />
                        <asp:RadioButton ID="RadioButton3" runat="server" ForeColor="Yellow" Text="Yellow" />
                        <br />
                        <asp:RadioButton ID="RadioButton4" runat="server" ForeColor="#33CC33" Text="Green" />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style2">Class</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Class Should be between 6-12" ForeColor="Red" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
                    </td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*Enter Valid Email Address" ForeColor="Red" ValidationExpression="^([a-zA-Z0-9]+@gmail\\.com)$" ControlToValidate="TextBox3"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="103px" ForeColor="#0000CC" />
                    </td>
                </tr>
                
            </table>
        </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
    </body>
</html>
