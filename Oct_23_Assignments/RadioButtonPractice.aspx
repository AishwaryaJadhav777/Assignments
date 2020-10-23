<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadiobuttonPractice.aspx.cs" Inherits="RadiobuttonPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="Radiobutton1" runat="server" Text="Male" GroupName="Gender" /><br />
            <asp:RadioButton ID="Radiobutton2" runat="server" Text="Female" GroupName="Gender" />

        </div>
        <p>
            <asp:Button ID="button1" runat="server" Text="Submit" OnClick="button1_Click" />
        </p>
    </form>
    <asp:Label runat="server" ID="genderid" />
        
</body>
</html>
