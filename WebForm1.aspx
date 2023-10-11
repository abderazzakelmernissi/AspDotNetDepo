<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPTPDEPOT1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 19px">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" Height="280px">
        <asp:Label ID="Label1" runat="server" Text="CODE J  :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Rechercher" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="TITRE :"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Modifier" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="PRIX : "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Supprimer" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="TYPE J :"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
            Text="Nouveau Journal" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="PERIODE "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="VILLE J "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </asp:Panel>
    </form>
</body>
</html>
