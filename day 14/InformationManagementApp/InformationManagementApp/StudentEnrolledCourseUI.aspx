<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentEnrolledCourseUI.aspx.cs" Inherits="InformationManagementApp.StudentEnrolledCourseUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<asp:GridView ID="enrolledCourseGridview" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
		<Columns>
			<asp:TemplateField HeaderText="Student Name">
				<ItemTemplate>
					<%#Eval("StudentName") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Registration Number">
				<ItemTemplate>
					<%#Eval("RegNo") %>
				</ItemTemplate>

			</asp:TemplateField>
			<asp:TemplateField HeaderText="Course Name">
				<ItemTemplate>
					<%#Eval("CourseName") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Course Code">
				<ItemTemplate>
					<%#Eval("CourseCode") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Enrollment Date">
				<ItemTemplate>
					<%#Eval("EnrollDate") %>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
		<FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
		<HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
		<PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
		<RowStyle BackColor="White" ForeColor="#003399" />
		<SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
		<SortedAscendingCellStyle BackColor="#EDF6F6" />
		<SortedAscendingHeaderStyle BackColor="#0D4AC4" />
		<SortedDescendingCellStyle BackColor="#D6DFDF" />
		<SortedDescendingHeaderStyle BackColor="#002876" />
	</asp:GridView>
</asp:Content>
