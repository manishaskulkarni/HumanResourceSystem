<%@ Page Title="" Language="C#" MasterPageFile="~/Crude.Master" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="WebUI.AddProject" %>
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
                Project Name:&nbsp;&nbsp;
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <br />
                <br />
                Client Name:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtcname" runat="server"></asp:TextBox>
                <br />
                <br />
                Start Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSdate" runat="server"></asp:TextBox>
                <br />
                <br />
                End Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtEdate" runat="server"></asp:TextBox>
                <br />
                <br />
                Budget:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBudget" runat="server"></asp:TextBox>
                <br />
                <br />
                Created By:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCreated" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:ImageButton ID="btnImgAdd" runat="server" ImageUrl="~/Images/Add.jpg" OnClick="btnImgAdd_Click" Width="71px" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                </div></div></div></div>

</asp:Content>
