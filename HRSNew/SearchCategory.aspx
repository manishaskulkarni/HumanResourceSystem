<%@ Page Title="" Language="C#" MasterPageFile="~/Crud.Master" AutoEventWireup="true" CodeBehind="SearchCategory.aspx.cs" Inherits="HRSNew.SearchCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style2">
        <div class="auto-style2" style="width:100%;">
            <div style="border-style:  groove; width:40%; float:left;">
             Category:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                </div>
                &nbsp;<asp:GridView ID="gvCat" runat="server" AutoGenerateColumns="False" DataKeyNames="CatID" GridLines="Horizontal" OnRowCommand="gvCat_RowCommand" OnSelectedIndexChanged="gvCat_SelectedIndexChanged" OnSelectedIndexChanging="gvCat_SelectedIndexChanging">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="CatID" DataNavigateUrlFormatString="ViewCategory.aspx?CatID={0}" DataTextField="CatName" HeaderText="Name" />
                    <asp:ButtonField CommandName="Edit" HeaderText="Update" Text="Edit" />
                </Columns>
            </asp:GridView>
            </div>
        <div style="width:50%; float:left;">
            <asp:ImageButton ID="btnImgEdit" runat="server" ImageUrl="~/Images/search.jpg" OnClick="btnImgEdit_Click" Width="64px" />
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
            <br />
            <br />
              <a href="AddCategory.aspx">Add New</a>  
            </div>
           
               

</asp:Content>
