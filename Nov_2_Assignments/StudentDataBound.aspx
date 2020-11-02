<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="DataBound.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 385px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table style="border:2px solid red; text-align:left; border-radius:2px;width:300px; padding-top:2px;background-color:lime;border-radius:8px;font-size:20px" />

            <asp:Repeater ID="Rp1" runat="server">
            <HeaderTemplate>
                <table style="width:200px; padding-top:0px; background-color:gold">
                    <td style="font-size:20px; text-align:center; height:48px">
                        <asp:Label ID="Lbl1" runat="server" Text="Student Profile" />
                    </td>
                </table>
                 
            </HeaderTemplate>
                <ItemTemplate>
<table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="StudentId"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label10" runat="server" Text='<%#Eval("StudentId") %>' />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("StudentName") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="StudentEmailID"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label12" runat="server" Text='<%#Eval("StudentEmailID") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="StudentMobileNum"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label13" runat="server" Text='<%#Eval("StudentMobileNum") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="StudentImage"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Image ID="img1" runat="server" Width="100px" ImageUrl='<%#"C:\\Users\\PAWAR\\Desktop\\pgms\\Dog.jpg" +Eval("StudentImage") %>'/>

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="StudentGender"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label14" runat="server" Text='<%#Eval("StudentGender") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="StudentRollNo"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label15" runat="server" Text='<%#Eval("StudentRollNo") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" Text="StudentCity"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label16" runat="server" Text='<%#Eval("StudentCity") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label9" runat="server" Text="StudentAddress"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label17" runat="server" Text='<%#Eval("StudentAddress") %>' />

                </td>
                <td>&nbsp;</td>
            </tr>
        </table>


                </ItemTemplate>
<FooterTemplate>
                    <table>
                        <tr>
                            <td>
                                @Developed by Aishwarya Jadhav<br />
                                @2020 All the CopyRight Reserved
                            </td>
                        </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            </div>
        
            
            
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
