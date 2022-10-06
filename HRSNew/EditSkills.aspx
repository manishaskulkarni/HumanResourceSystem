<%@ Page Title="" Language="C#" MasterPageFile="~/Crud.Master" AutoEventWireup="true" CodeBehind="EditSkills.aspx.cs" Inherits="HRSNew.EditSkills" %>
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
                Skill Name:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <br />
                <br />
                Description:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                <br />
                <br />
                Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddl" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                Created By:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtcreated" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:ImageButton ID="btnImgEdit" runat="server" ImageUrl="~/Images/updt.png" OnClick="btnImgEdit_Click" Width="53px" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                </div></div></div></div>
</asp:Content>
