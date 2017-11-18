<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="LinQ.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>

            <table style="width: 100%;">
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="txtBoxID" runat="server" Width="144px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtBoxName" runat="server" Width="142px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rbtnGender" runat="server" RepeatDirection="Horizontal" Width="170px">
                            <asp:ListItem Selected="True">Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAdd" runat="server"  Text="Add" />
                    </td>
                    
                </tr>
            </table>

        </div>
        <asp:GridView ID="gvProductData" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
