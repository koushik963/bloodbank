<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserHome.aspx.cs" Inherits="Home2" %>

<!DOCTYPE html>


<head>
    <title>Share a little !! Care a little !!</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="WOW Slider, javascript slideshow, slideshow html" />
    <meta name="description" content="WOWSlider created with WOW Slider, a free wizard program that helps you easily generate beautiful web slideshow" />
    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css">
    <link href="css/bootstrap-responsive.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="engine1/jquery.js"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <!-- Script Files  -->
    <script src="js/myScript.js"></script>
    <link href="css/myStyle.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
        <center>
	<div class="headbar"><br>
<img src="kavya1.png">
	</div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl_Username" runat="server" ForeColor="#CC0000"></asp:Label>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkBtn_ManageAccount" runat="server" ForeColor="#CC0000" OnClick="LinkBtn_ManageAccount_Click">Manage Account</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkBtn_Loguout" runat="server" ForeColor="#CC0000" OnClick="LinkBtn_Loguout_Click" >Logout</asp:LinkButton>
            &nbsp; <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#CC0000" OnClick="LinkBtn_Invite_Click" >INVITE FRIENDS</asp:LinkButton>
            &nbsp;<br>	 <br />
	<div> 
     <h1>Looking for Blood ?</h1><br>
        <font color="#A00000" size="5">
&nbsp;Zipcode: 
        <asp:TextBox ID="Tb_Zip" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;Blood type<asp:DropDownList ID="DDL_BloodGroups" runat="server">
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
&nbsp;<br />
        <br />
        <asp:Button ID="Btn_Submit" runat="server" Text="SUBMIT" OnClick="Btn_Submit_Click" Font-Size="15px" ForeColor="#990000" Height="30px" Width="80px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Lbl_Msg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/register.gif" OnClick="ImageButton1_Click" />
        <br />
        <br />
        <br />
 </font>
	</div>
	</center>
        <br />
        <br>
        <br>
        <!-- Start WOWSlider.com BODY section -->
        <div id="wowslider-container1">
            <div class="ws_images">
                <ul>
                    <li>
                        <img src="data1/images/xx.jpg" alt="" title="Donate Blood Save a Life" id="wows1_1" /></li>
                    <li>
                        <img src="data1/images/cap_white_logo1.jpg" alt="Donate Blood Save a Life" title="Donate Blood Save a Life" id="wows1_0" /></li>

                    <li>
                        <img src="data1/images/bloodbagnotext0001.jpg" alt="" title="Donate Blood Save a Life" id="wows1_2" /></li>
                </ul>
            </div>
            <div class="ws_bullets">
                <div>
                    <a href="#" title="Donate Blood Save a Life">
                        <img src="data1/tooltips/cap_white_logo1.jpg" alt="cap_white_logo1" />1</a>
                    <a href="#" title="Donate Blood Save a Life">
                        <img src="data1/tooltips/xx.jpg" alt="xx" />2</a>
                    <a href="#" title="Donate Blood Save a Life">
                        <img src="data1/tooltips/bloodbagnotext0001.jpg" alt="bloodbagnotext-0001" />3</a>
                </div>
            </div>
            <span class="wsl"><a href="http://wowslider.com"></a></span>
            <div class="ws_shadow"></div>
        </div>
        <script type="text/javascript" src="engine1/wowslider.js"></script>
        <script type="text/javascript" src="engine1/script.js"></script>
        <!-- End WOWSlider.com BODY section -->

        <br>
        <br>
        <br>
        <br>
        <asp:GridView ID="Gv_Data" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Lucida Sans" HorizontalAlign="Center">
            <FooterStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Lucida Sans" HorizontalAlign="Center" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>

        <br>
        <br>
        <br>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	  <asp:Image ID="Image1" runat="server" ImageUrl="~/kavya.png" Height="400px" Width="400px" /><br>
        <br>
        <br>
        .
        <br>
        <br>
        <br>
        <br>
    </form>
</body>
</html>