<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBoundControls.aspx.cs" Inherits="DataBound.DataBoundControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 292px;
        }
        .auto-style2 {
            width: 100%;
            height: 333px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border:2px solid red; text-align:left; border-radius:2px;width:300px; padding-top:2px;background-color:lime;border-radius:8px;font-size:20px" />

                <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        EmpID:
                        <asp:Label ID="EmpIDLabel" runat="server" Text='<%# Eval("EmpID") %>' />
                        <br />
                        EmpName:
                        <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                        <br />
                        EmpEmailID:
                        <asp:Label ID="EmpEmailIDLabel" runat="server" Text='<%# Eval("EmpEmailID") %>' />
                        <br />
                        EmpMobileNum:
                        <asp:Label ID="EmpMobileNumLabel" runat="server" Text='<%# Eval("EmpMobileNum") %>' />
                        <br />
                        EmpImage:
                        <asp:Label ID="EmpImageLabel" runat="server" Text='<%# Eval("EmpImage") %>' />
                        <br />
                        EmpGender:
                        <asp:Label ID="EmpGenderLabel" runat="server" Text='<%# Eval("EmpGender") %>' />
                        <br />
                         <br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Employee1]"></asp:SqlDataSource>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p></div>
        </form>
</body>
</html>
