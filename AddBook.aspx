<%@ Page Title="AddBooks" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="AddBook" %>

<%@ Register Src="~/BookDetail.ascx" TagPrefix="uc1" TagName="BookDetail" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        #txtDescription {
            width: 304px;
        }
        .auto-style2 {
            height: 96px;
        }
        .auto-style3 {
            height: 62px;
        }
        .auto-style4 {
            height: 61px;
        }
    </style>
</asp:Content>
<asp:Content  ContentPlaceHolderID="ContentPlaceHolder2" ID="Content3" runat="server">
     
     <link rel="stylesheet" href="StyleSheet.css" />

    <div id="booksMain">
       To add a book, fill out all the boxes below and click Save Book.
        <br />
        <br />
        <table cellspacing="30">
            <asp:Label ID="lblCheckBelow" runat="server" Text=""></asp:Label>

            <tr><td><uc1:BookDetail runat="server" id="bookDetail" /></td></tr>
            
            <tr>
                <td><b><label for="txtGenre">Genre :</label> </b></td>
                <td>
                    <asp:DropDownList ID="ddGenre" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAddGenre" runat="server" Text="Add" CausesValidation="false" OnClick="btnAddGenre_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtNewGenre" placeholder="Add New Genre" runat="server" Text=""></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td><b>
                    <label for="txtNumPages">Number of Pages :</label></b>
                </td>
                <td>
                    <asp:TextBox ID="txtNumPages" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtNumPages" runat="server" ForeColor="Red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><b><label for="txtLent">Lent to a friend :</label></b> 
                </td>
                <td>
                    <asp:DropDownList ID="cbLent" runat="server"> 
                    <asp:ListItem Text="YES" Value="1"></asp:ListItem>
                    <asp:ListItem Text="NO" Value="2"></asp:ListItem></asp:DropDownList>
                 
                  
                </td>
            </tr>
             <tr>
                <td><b><label for="txtFriendName">Name of a friend that the book is lent to :</label></b> 
                </td>
                <td>
                    <asp:TextBox ID="txtFriendName" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtFriendName" runat="server"  ForeColor="Red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style2"> <b>Comments : </b>
                </td>
                <td class="auto-style2">
                   <textarea id="txtComments" runat="server" rows="2" Width="200px"></textarea>
                    
                </td>
            </tr>
            <tr>
                <td>

        <asp:Button ID="saveButton" runat="server" Text="Save Book" OnClientClick="saveButton_Click" OnClick="saveButton_Click" />
                </td>
                <td>
                            <asp:Button ID="cancelButton" runat="server" Text="Cancel Book" OnClientClick="cancelButton_Click" OnClick="cancelButton_Click" />

                            

                </td>
            </tr>
            <tr><td><asp:Label ID="lblErro" runat="server" Text=""></asp:Label></td></tr>
        </table>
    </div>
</asp:Content>
