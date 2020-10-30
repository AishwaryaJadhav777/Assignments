<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddmissionForm.aspx.cs" Inherits="ASPValidations.AddmissionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            height: 25px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style8 {
            height: 42px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style9 {
            height: 43px;
        }
        .auto-style2 {
            width: 398px;
            height: 50px;
        }
        .auto-style10 {
            width: 398px;
            height: 93px;
        }
        .auto-style11 {
            height: 93px;
        }
        .auto-style12 {
            width: 398px;
            height: 51px;
        }
        .auto-style13 {
            height: 51px;
        }
        .auto-style14 {
            height: 44px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style15 {
            height: 44px;
        }
        .auto-style16 {
            height: 50px;
        }
        .auto-style17 {
            height: 43px;
            width: 398px;
            margin-bottom: 96px;
        }
        .auto-style18 {
            height: 42px;
        }
        .auto-style20 {
            width: 398px;
            height: 40px;
        }
        .auto-style21 {
            height: 40px;
        }
        </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <h3>Addmission Form</h3>
        <div>
            <table style="width: 124%; height: 135px;">
                <tr>
                    <td class="auto-style8">FirstName</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*FirstName Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style17">LastName</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*LastName Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Fathers Name</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Fathers Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style14">Mothers Name</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="TextBox4" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Mothers Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style12">Gender</td>
                    <td class="auto-style13">
                        <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Black" Text="Male" GroupName="gender" />
                        &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" ForeColor="Black" Text="Female" GroupName="gender" />
                    </td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Aggregate</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox5" runat="server" BackColor="#3399FF" Width="205px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Enter Aggregate" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Aggregate must be greater than 60" MaximumValue="100" MinimumValue="60" Type="Integer" ForeColor="#FF3300"></asp:RangeValidator>
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="CSE"/></td>
                    <td class="auto-style21">
                        <br />
                  &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Computer Operating Architecture" /><br />
                  &nbsp;<asp:CheckBox ID="CheckBox2" runat="server" Text="DataStructure" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                  &nbsp;<asp:CheckBox ID="CheckBox3" runat="server" Text="Computer Network" />
                    </td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:RadioButton ID="RadioButton4" runat="server" Text="ECC" OnCheckedChanged="RadioButton4_CheckedChanged" /></td>
                    <td class="auto-style21">
                        <br />
                  &nbsp;<asp:CheckBox ID="CheckBox4" runat="server" Text="MicroContoller" /><br />
                  &nbsp;<asp:CheckBox ID="CheckBox5" runat="server" Text="Logic Design" /><br />
                  &nbsp;<asp:CheckBox ID="CheckBox6" runat="server" Text="Analog Communication" />
                    </td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" Width="103px" ForeColor="#0000CC" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
    
    </body>
</html>
