<%@ Page Title="" Language="C#" MasterPageFile="~/Crude.Master" AutoEventWireup="true" CodeBehind="AddSkill.aspx.cs" Inherits="WebUI.AddSkill" %>
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
                Skill Name:
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <br />
                <br />
                Description:
                <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
                <br />
                <br />
                Category :&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Ddl" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                Created By:&nbsp;
                <asp:TextBox ID="txtcreated" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:ImageButton ID="btnImgAdd" runat="server" ImageUrl="~/Images/Add.jpg" OnClick="btnImgAdd_Click" Width="77px" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                </div></div></div></div>

</asp:Content>
