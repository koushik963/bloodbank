<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Invite.aspx.cs" Inherits="Invite" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
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
	</div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkBtn_Home" runat="server" ForeColor="#CC0000" OnClick="LinkBtn_Home_Click">HOME</asp:LinkButton><br>	
	<div> 
     <h1>INVITE FRIENDS!!!</h1>
        <br>
	</div>
	</center>
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
        <br>

        <div class="form span4 offset2">

            <h1>Details</h1>
            <br>
            <br>
            <label>
                Full Name*:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tb_FirstName" runat="server"></asp:TextBox>
            </label>
            <br>
            <label>
                Email Id*:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Tb_EmailId" runat="server" TextMode="Email"></asp:TextBox>
            </label>
            <br>

            <asp:Label ID="Lbl_msg" runat="server"></asp:Label><br /><br />
            <asp:Button ID="Btn_Submit" runat="server" Text="INVITE" style="color: #A00000" OnClick="Btn_Submit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Reset" runat="server" OnClientClick="this.form.clear();return true" Text="RESET" style="color: #A00000" OnClick="Btn_Reset_Click"/>
            &nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            
        </div>
        <br>
        <br>
        <br>
        <img src="kavya.png" width="400px" height="400px">
        <br>
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