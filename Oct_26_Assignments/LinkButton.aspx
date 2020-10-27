<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkButton.aspx.cs" Inherits="CalenderWebFormASP.LinkButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
            
        <h3>It is HyperLink style button</h3>
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Facebook</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Instagram</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">WhatsApp</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Twitter</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Youtube</asp:LinkButton>
        </div>
        <div>
            <asp:LinkButton ID="Linkbutton6" runat="server" OnCommand="Linkbutton6_Command">Coursera</asp:LinkButton>
        </div>
        <p>
            <asp:Label runat="server" ID="Label1" />
        </p>
        
    </form>
</body>
</html>
