<%@ Page Title="" Language="C#" MasterPageFile="~/Crud.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="HRSNew.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%; ">
        <div class="auto-style2">
            <div style="width:40%; float:left;">
                <p></p>
            </div>
            <div style="width:60%; float:left;">
            <div style="width:50%; border-style:  groove; float: left">
                First Name:&nbsp;
                <asp:TextBox ID="txtfn" runat="server"></asp:TextBox>
                <br />
                <br />
                Last Name:&nbsp;
                <asp:TextBox ID="txtln" runat="server"></asp:TextBox>
                <br />
                <br />
                DOB:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
                <br />
                <br />
                E-mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
                <br />
                <br />
                DOJ:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDoj" runat="server"></asp:TextBox>
                <br />
                <br />
                Created By:&nbsp;&nbsp;
                <asp:TextBox ID="txtcreated" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:ImageButton ID="btnImgEdit" runat="server" ImageUrl="~/Images/updt.png" OnClick="btnImgEdit_Click" Width="56px" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                </div></div></div></div>
</asp:Content>
