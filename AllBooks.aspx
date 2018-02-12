<%@ Page Title="Books" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllBooks.aspx.cs" Inherits="AllBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 273px;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" ID="Content2" runat="server">
     <link rel="stylesheet" href="StyleSheet.css" />
    <link rel="stylesheet" href="css/contact.css" />
    <div id="recipesMain">
       
        <table cellspacing="30">
            <asp:Label ID="lblCheckBelow" runat="server" Text=""></asp:Label>
            <tr>
                <td class="auto-style1">
                    <asp:PlaceHolder ID="BookPlaceHolder" runat="server"></asp:PlaceHolder>
                     
                     <div runat="server" id="multiRecipe">
                         <asp:Label ID="lblerror" runat="server" Text="Label"></asp:Label>
                         </div>
                </td>
                
            </tr>
        </table>
    </div>
    
    
   

</asp:Content>