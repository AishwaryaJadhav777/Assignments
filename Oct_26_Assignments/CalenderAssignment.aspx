<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calenderAssignment.aspx.cs" Inherits="CalenderWebFormASP.calenderAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
             <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Names="Arial Black" Font-Size="Medium" ForeColor="Yellow" >List Of Holidays in 2020</asp:Label><br />

             </p>
            <asp:Calendar ID="Calendar1" runat="server" ShowGridLines="true" OnDayRender="Calendar1_DayRender1" OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged"></asp:Calendar>
            
        </div>
        <p>
            <asp:Label ID="LabelAction" runat="server" />
        </p>
       
    </form>
</body>
</html>
