<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BookDetail.ascx.cs" Inherits="WebUserControl" %>
<div id="booksMain">
<table cellspacing="30">
            <tr>
               <td class="BookName"><b><label for="txtTitle">Name:</label></b></td>
               <td><asp:TextBox ID="txtTitle" runat="server" Width="200px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="reqName" ControlToValidate="txtTitle" runat="server" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
                <td class="auto-style3"><b><label for="txtAuthor">Author :</label></b> 
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtAuthor" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtAuthor" runat="server"  ForeColor="Red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"><b><label for="txtIsbn">ISBN Number :</label></b> 
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtIsbn" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
    </table>
    </div>
&nbsp;

