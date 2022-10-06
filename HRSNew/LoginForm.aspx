<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="HRSNew.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
form {
    border: 1px  unset #f1f1f1;
}

input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

button {
    background-color: royalblue;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}

button:hover {
    opacity: 0.8;
}

.cancelbtn {
    width: auto;
    padding: 10px 18px;
    background-color: #f44336;
}

.imgcontainer {
    text-align: left;
    margin: 24px 0 12px 0;
}

img.avatar {
    width: 40%;
    border-radius: 65%;
}

.container {
    padding: 16px;
    
}
.container1 {
    padding: 16px;
    width:30%;
}
.container2 {
    padding: 16px;
    width:10%;
}
span.psw {
    float: right;
    padding-top: 16px;
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
input[type=text]:focus {
    background-color: lightblue;
}
input[type=password]:focus {
    background-color: lightblue;
}
</style>
</head>
<body style="background-image:url('/Images/hrs.jpg'); height: 610px;">
   <%-- <h2> HR Login </h2>--%>
    <form id="form1" runat="server" action="/action_page.php">
        <%--<div>--%>
            

<%--<form action="/action_page.php">--%>
  <div class="imgcontainer">
    <img src="Images/hrslogo.png" alt="Avatar" class="avatar" style="width: 13%; height: 70px;" />
  </div>

  <div class="container1">
    <label><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="uname" required="required" />

    <label><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="psw" required="required" />
   </div>
        <div class="container2">
    
   <span> <a href="Home.aspx">Login</a></span>
            </div>
        <div class="container2">
    <input type="checkbox" checked="checked" /> Remember me
  </div>

  <div class="container">
     <a href="LoginForm.aspx">Cancel</a>
    <span class="psw">Forgot <a href="#">password?</a></span>
  <%--</div>
</form>--%>

        </div>
    </form>
</body>
</html>
