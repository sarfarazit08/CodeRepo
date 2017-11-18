<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Performance.aspx.cs" Inherits="Cryptography.Performance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        Results for 10000 iterations for plain text size of 104.
    </div>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvResults" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
