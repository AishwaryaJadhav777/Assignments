<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListAssignment.aspx.cs" Inherits="CookiesASP.DataListAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>The DataList shows date of the DataTable</p>
            <asp:DataList ID="Datalist1" runat="server" Height="17px" Width="170px">
 
             <ItemTemplate>
                    <asp:Table ID="table1" runat="server" CellPadding="2" CellSpacing="0" Border="1" /> 
                    <tr>
                        <td>
                            <strong>FirstName</strong><span class="HR"><%# Eval("FirstName") %></span><br />
                            <strong>LastName</strong><span class="TechLead"><%# Eval("LastName") %></span><br />
                            <strong>Designation</strong><span class="Data Analyst"><%# Eval("Designation" )%></span>
                            <strong>Location</strong><span class="junior eng"><%# Eval("Location" )%></span>
                            <strong>Country</strong><span class="intern"><%# Eval("Country" )%></span>

                        </td>
                    </tr>
                </ItemTemplate>  
                </asp:DataList>
        </div>
    </form>
</body>
</html>
