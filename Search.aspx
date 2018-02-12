<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" ID="Content2" runat="server">
     <link rel="stylesheet" href="StyleSheet.css" />
    <link rel="stylesheet" href="css/contact.css" />
    <link rel="stylesheet" href="css/recipes.css" />
    <div class="container">
			<div class="container-contact">
  <table>
      <tr>
          <td>
              <asp:Label ID="lblFriend" runat="server" Text="Search By Friend"></asp:Label>
          </td>
          <td>
                <asp:DropDownList ID="ddFriend" runat="server">
                <asp:ListItem Value="0">All</asp:ListItem>
                </asp:DropDownList>
          </td>
      </tr>
      <tr>
          <td><asp:Label ID="lblGenre" runat="server" Text="Search By Genre"></asp:Label> </td>
          <td>
                <asp:DropDownList ID="ddGenre" runat="server">
                <asp:ListItem Value="0">All</asp:ListItem>
                </asp:DropDownList>
          </td>
      </tr>
      
      <tr><td><asp:Button Text="Search Books" runat="server" ID="BtnSearch" CausesValidation="false" onclick="BtnSearch_Click" /></td></tr>
  </table>
      

    
   

    
    
    
   

    

  
</div>
<div>
    <span>Search Results: </span><span runat="server" id="searchedItemsCount"></span>
</div>
<div runat="server" id="searchedItems">
    
</div>


	</div> 
</asp:Content>