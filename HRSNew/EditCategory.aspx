<%@ Page Title="" Language="C#" MasterPageFile="~/Crud.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="HRSNew.EditCategory" %>
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
            Categoty Name:&nbsp;
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;<br />
                <br />
            Description:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                <br>
                <br />
            Created By:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCreated" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:ImageButton ID="btnImgEdit" runat="server" ImageUrl="~/Images/updt.png" OnClick="btnImgEdit_Click" Width="52px" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                <br />
                </div></div></div></div>

</asp:Content>
