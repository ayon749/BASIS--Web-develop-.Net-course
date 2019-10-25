﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="InformationManagementApp.Student_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<asp:GridView ID="studentGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
		<Columns>
			<asp:TemplateField HeaderText="Student Name">
				<ItemTemplate>
					<%#Eval("StudentName") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Student Email">
				<ItemTemplate>
					<%#Eval("StudentEmail") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Student Reg No">
				<ItemTemplate>
					<%#Eval("RegNo") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Student Mobile No">
				<ItemTemplate>
					<%#Eval("MobileNo") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Student Age">
				<ItemTemplate>
					<%#Eval("Age") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Student Address">
				<ItemTemplate>
					<%#Eval("Address") %>
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
