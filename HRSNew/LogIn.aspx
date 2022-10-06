<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HRSNew.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .form {
            border: 0px solid #f1f1f1;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: compact;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        button {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

        .imgcontainer {
            text-align: left;
            margin: 24px 0 12px 0;
            width: 100%;
        }

        .container {
            padding: 16px;
            background-image: url("hrs.jpg");
            opacity: 0.5;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        span.hrs {
            float: unset;
            /*padding-top: 16px;*/
        }

        .division {
            width: 50%;
            /*height:100px;*/
            float: left;
        }

        .division1 {
            width: 50%;
            height: 100px;
            float: right;
        }

        .division2 {
            width: 100%;
            /*height:100px;*/
            float: left;
        }
        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

            .cancelbtn {
                width: 100%;
            }
        }

        .auto-style3 {
            margin-top: 0px;
        }

        .wrap {
            width: 100%;
            background: white none repeat scroll 0% 0%;
        }
        /*.image {
 background-image: url('/HrImages/hrs.jpg');
  background-size: cover;
  opacity: 0.5;
  height: 100vh;
  max-height: 350px;
  min-height: 200px;
  position: absolute;
}*/
        .image:before {
            content: '';
            position: absolute;
            top: 0;
            right: 0;
            left: 0;
            bottom: 0;
            background: rgba(0,0,0,0.7);
        }

        .text {
            color: black;
            opacity: 2.5;
            font-weight: 500;
            position: relative;
        }

        .auto-style4 {
            background-image: url('/Images/hrs.jpg');
            background-size: unset;
            opacity: 0.8;
            height: 563px;
            position: page;
        }
    </style>
</head>
<body style="height: 557px;">


    <form runat="server">
        <div class="imgcontainer">
            <div class="division"><span>
                <asp:Image ID="Image1" runat="server" Height="52px" ImageUrl="~/Images/hrslogo.png" Width="125px" /></span></div>
            <h2><span class="hrs"><i>Human Resource Software</i></span></h2>
        </div>
        <div class="auto-style4">
            <div class="division2">

                <div class="text" style="opacity: 2">
                    <label><b>UserId</b></label>
                </div>
                <asp:TextBox ID="txtUserId" runat="server" Width="159px"></asp:TextBox>


                <div class="text">
                    <label><b>Password</b></label>
                </div>
                <span>
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="20%" Style="border: 1px   thick black;"></asp:TextBox></span>

            </div>

            <div class="division2">
                <asp:ImageButton ID="ImageBtn" runat="server" CssClass="auto-style3" Height="34px" ImageUrl="~/Images/login-button-png-hi.png" Width="6%" OnClick="ImageButton1_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                 <div class="icon-bar">
                 <a href="Home.cs"><b>Login</b></a>
            </div>
        </div>
    </form>



</body>
</html>
