<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Full Name*"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_FirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Blood Group*"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDL_BloodGroups" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>A+</asp:ListItem>
            <asp:ListItem>A-</asp:ListItem>
            <asp:ListItem>B+</asp:ListItem>
            <asp:ListItem>B-</asp:ListItem>
            <asp:ListItem>AB+</asp:ListItem>
            <asp:ListItem>AB-</asp:ListItem>
            <asp:ListItem>O+</asp:ListItem>
            <asp:ListItem>O-</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender*"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Ddl_Gender" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Date Of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_DOB" runat="server"  TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Mobile Number*"></asp:Label>
&nbsp;<asp:TextBox ID="Tb_Mobilenum" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="State*"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Ddl_State" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>AL</asp:ListItem>
            <asp:ListItem>CA</asp:ListItem>
            <asp:ListItem>OH</asp:ListItem>
            <asp:ListItem>NY</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="H.No*"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="Tb_HouseNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Street*"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_Street" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="City*"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_City" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Zip Code*"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_ZipCode" runat="server" MaxLength="5"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="UserID" runat="server" Text="User ID*"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="Tb_UserId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Password*"></asp:Label>
&nbsp;
        <asp:TextBox ID="Tb_Pwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Email Id*"></asp:Label>
&nbsp;
        <asp:TextBox ID="Tb_EmailId" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Please Confirm your availablity*"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="Ddl_status" runat="server">
            <asp:ListItem>Available</asp:ListItem>
            <asp:ListItem>Unavailable</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Lbl_msg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Btn_Submit" runat="server" OnClick="Btn_Submit_Click" Text="SUBMIT" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Reset" runat="server" OnClientClick="this.form.clear();return true" Text="RESET" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
