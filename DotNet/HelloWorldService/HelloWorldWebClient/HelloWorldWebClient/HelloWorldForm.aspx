<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorldForm.aspx.cs" Inherits="HelloWorldWebClient.HelloWorldForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 278px;
        }
        .auto-style2 {
            width: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border: 3px dotted yellow;">
            <tr>
                <td class="auto-style2"><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtBoxName" runat="server"></asp:TextBox><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                <td><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
            </tr>            
        </table>        
    </div>
    </form>
</body>
</html>
