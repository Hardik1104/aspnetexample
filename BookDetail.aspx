<%@ Page Title="Book Detail" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetail.aspx.cs" Inherits="BookDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 273px;
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
                        <td >
                            <asp:Button runat="server"  ID="btnDel" OnClick="DelRecipe" Text="Delete" />
                        </td>
                        <td>
                            <asp:Button runat="server"  ID="btnUp" Text="Update" OnClick="btnUp_Click" />
                        </td>

                    </tr>

                </table>
            <p  >
                
            </p>
            <p  class="item">
                <span><b>Book Name:</b></span>
                <span runat="server" id="bookName"></span>
            </p>
            <p class="item">
                <span><b>Author :</b></span>
                <span runat="server" id="author"></span>
            </p>
            <p class="item">
                <span><b>ISBN :</b></span>
                <span runat="server" id="isbn"></span>
            </p>
            <p class="item">
                <span><b>Genre :</b></span>
                <span runat="server" id="Genre"></span>
            </p>
            <p class="item">
                <span><b>Page Count:</b></span>
                <span runat="server" id="count"></span>
                </p>
                <p class="item">
                <span><b>Lent to  Friend:</b></span>
                <span runat="server" id="lent"></span>
            </p>
                <p class="item">
                <span><b>Friend Name :</b></span>
                <span runat="server" id="fName"></span>
            </p>
                <p class="item">
                <span><b>Description :</b></span>
                <span runat="server" id="description"></span>
            </p>
            
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            
            </div>
            <div runat="server" id="multiRecipe">
                
            </div>
        </div>
    </div>
</asp:Content>