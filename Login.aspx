<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="USERNAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Tb_Username" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="PASSWORD"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_Pwd" runat="server" TextMode="Password"></asp:TextBox>
    
        <br />
        <br />
        <asp:Label ID="Lbl_msg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Btn_Login" runat="server" OnClick="Btn_Login_Click" Text="LOGIN" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="For Got Password" />
    
    </div>
    </form>
</body>
</html>
