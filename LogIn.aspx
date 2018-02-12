<%@ Page Title="SignIn" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<script runat="server">

    
</script>


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
     <br />
    <table>
        <tr>
            <td>
                <label class="m-l-md">User Name:</label>
            </td>
            <td>
                <asp:TextBox ID="txtUser" runat="server" CssClass="m-l-md width-auto "></asp:TextBox>
    
            </td>
        </tr>
        <tr>
            <td>
               <label class="m-l-md">Password:</label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="m-l-md width-auto "></asp:TextBox>
    
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="m-l-md" OnClick="btnLogin_Click1" />
            </td>

        </tr>
        <tr>
            <td>
                <asp:Literal ID="litStatus" runat="server"></asp:Literal>
            </td>

        </tr>
    </table>
</asp:Content>
