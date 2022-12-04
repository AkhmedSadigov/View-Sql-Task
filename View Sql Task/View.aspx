<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="View_Sql_Task.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<link href="style.css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text="Category Name"></asp:Label>
            <asp:TextBox ID="txtbox1" runat="server" OnTextChanged="txtbox1_TextChanged"></asp:TextBox>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnPageIndexChanging="datagrid_PageIndexChanging" PageSize="4" ></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btn1" runat="server" CssClass="button" Text="Search" OnClick="btn1_click" />
        </div>
    </form>
</body>
</html>
