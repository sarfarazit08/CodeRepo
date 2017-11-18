<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameWebForm.aspx.cs" Inherits="HelloWebClient.NameWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 71px;
        }
        .auto-style2 {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border: 1px dotted red;">
                <tr>
                    <td class="auto-style1"><strong>Name : </strong></td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBoxName" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                    <td><strong>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></strong></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

