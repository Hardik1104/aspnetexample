<%@ Page Title="Update Book Detail" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 23%;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" ID="Content2" runat="server">
     <div class="container">
        <link rel="stylesheet" href="css/contact.css" />
        <link rel="stylesheet" href="css/recipes.css" />
         <link rel="stylesheet" href="StyleSheet.css" />
		<div class="container-contact">
            <div runat="server" id="singleRecipe">
                <table style="width:100%">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblBookName" runat="server" Text="Book Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblAuthor" runat="server" Text="Author :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                     <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblISBN" runat="server" Text="ISBN :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtIsbn" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblGenre" runat="server" Text="Genre :"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="txtGenre" runat="server">
                            </asp:DropDownList>
                        </td>

                    </tr>
                   <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblCount" runat="server" Text="Page Count :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                     <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblLent" runat="server" Text="Lent to  Friend:"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="txtLent" runat="server" Width="150px">
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:DropDownList>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblFName" runat="server" Text="Friend Name :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblDes" runat="server" Text="Description :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDes" runat="server" Height="99px" TextMode="MultiLine"></asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style2" >
                            
                            <asp:Button runat="server"  ID="btnUp" Text="Update" OnClick="btnUp_Click" />
                        </td>
                        <td>
                            <asp:Button runat="server"  ID="btnDel" OnClick="DelRecipe" Text="Delete" />
                        </td>

                    </tr>
                    <tr><td class="auto-style2"></td></tr>


                </table>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
          </div>
        </div>
    </div>
</asp:Content>
