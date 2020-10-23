<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GeneralTechnique.aspx.cs" Inherits="GeneralTechnique" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" name="TextBox1" />
            <button>Submit</button>
            <br /><br />

            <asp:TextBox ID="TextBox2" runat="server" />
            <asp:Button ID="button1" runat="server" Text="SUBMIT" OnClick="button1_Click" />
        </div>
    </form>
</body>

</html>
