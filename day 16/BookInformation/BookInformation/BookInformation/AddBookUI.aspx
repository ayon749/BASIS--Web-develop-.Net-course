<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBookUI.aspx.cs" Inherits="BookInformation.AddBookUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="inputName">Name</label>
        <input type="text" runat="server" class="form-control" id="inputName" placeholder="Book Name">
    </div>
    <div class="form-group">
        <label for="inputIsbn">ISBN</label>
        <input type="text" runat="server" class="form-control" id="inputIsbn" placeholder="ISBN">
    </div>
    <div class="form-group">
        <label for="inputAuthor">Author</label>
        <input type="text" runat="server" class="form-control" id="inputAuthor" placeholder="Author">
    </div>
    <asp:Button ID="saveButon" runat="server" Text="Save" OnClick="saveButon_Click" />
    
    <br/>
    <asp:Label ID="successMessage" runat="server" ></asp:Label>
</asp:Content>
