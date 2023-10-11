<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ASPTPDEPOT1.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 253px">
    
        <asp:Label ID="Label1" runat="server" Text="PRIX"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            Height="16px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            style="margin-left: 0px" Width="200px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="NVPrix" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="33px" 
            style="margin-top: 18px" Visible="False"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="22px" onclick="Button3_Click" 
            Text="Okey " Visible="False" Width="119px" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="130px" 
            style="margin-left: 37px; margin-top: 15px" Width="280px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Modifier" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="supprimer" />
        <br />
&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
