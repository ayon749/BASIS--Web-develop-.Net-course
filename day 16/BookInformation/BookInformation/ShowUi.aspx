<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowUi.aspx.cs" Inherits="BookInformation.ShowUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="inputNameSearch">Name</label>
        <input type="text" runat="server" class="form-control" id="inputNameSearch" placeholder="Book Name">
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
    </div>
    <asp:GridView ID="searchGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:TemplateField HeaderText="Book Name">
                <ItemTemplate>
                    <%#Eval("Name") %>
                </ItemTemplate>
            </asp:TemplateField >
            <asp:TemplateField HeaderText="ISBN">
                <ItemTemplate>
                    <%#Eval("ISBN") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Author" >
                <ItemTemplate>
                    <%#Eval("Authoor") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    
</asp:Content>
