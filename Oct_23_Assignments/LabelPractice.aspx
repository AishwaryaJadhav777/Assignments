<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelPractice.aspx.cs" Inherits="LabelPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is an Example of document upload</title>
    

    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h4>Provide the below Information</h4>

            <asp:Label ID="Label1" runat="server" Text="Username" BackColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="#0000CC" />

            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 47px" Width="165px" /><br />

            <asp:Label ID="Label2" runat="server" Text="Upload a file" BackColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="#000099" />

            <asp:FileUpload ID="FileUpload" runat="server" style="margin-left: 32px" Width="261px" />
            
                    

        </div>
    </form>
</body>
</html>
