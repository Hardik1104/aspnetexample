<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" runat="server" ID="Content3">
    <link rel="stylesheet" href="StyleSheet.css" />
    <div id="mainPage">
        <br />
        <table>
            <tr>
                <td><div id="mainContent1">
        This web-application has basic functionalities where you can view books,
        <br />
        add a book or search a book from the list of all available books.
        <br />
        This website has over 100 books of different kinds from different authors.
        <br />
        <br />
        <p>
            1). To view all the books, 
        <br />
            Click <strong><em>Books</em></strong> --> This allows system to view all the books in the database.
        </p>
        <br />
        <p>
            2). To Add a book, 
        <br />
            Click on <strong><em>Add a book</em></strong> --> then, fill out all the input boxes to get  -->  hit<br />
            <em>Save the book.</em>.
        </p>
        <br />
        <p>
            3). To search a book from all the books, 
        <br />
            Click <strong><em>Search</em></strong> --> Enter the search criteria in the input box .<br />
            --> System will display the search results. 
        </p>
        <br />
        <p>
            Moreover, the user will be able to navigate to any of the web-pages 
            <br />
            using the link in the navigation bar on the left.
        </p>
            </tr>

        </table>
        
        
    </div>
    
   
</asp:Content>
