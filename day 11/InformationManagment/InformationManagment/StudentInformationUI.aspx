<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInformationUI.aspx.cs" Inherits="InformationManagment.StudentInformationUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Student Information Form</h2>
	 <div class="form-group">
    <label for="inputStudentName">Student Name</label>
		 <input type="text" class="form-control" id="inputStudentName" runat="server" placeholder="Enter Name" />
	 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputStudentName" Display="Dynamic" ErrorMessage="Name can't be empty" ForeColor="Red"></asp:RequiredFieldValidator>
  </div>
	<div class="form-group">
    <label for="inputEmailAddress">Email Address</label>
    <input type="email" runat="server"  class="form-control" id="inputEmailAddress" placeholder="abc@gmail.com">
  </div>
	<div class="form-group">
    <label for="inputRegNo">Registration No.</label>
    <input type="text" class="form-control" runat="server" id="inputRegNo" placeholder="xxx-x-xx-xxx">
  </div>
	<div class="form-group">
    <label for="inputMobileNo">Mobile No.</label>
    <input type="text" class="form-control" runat="server" id="inputMobileNo" placeholder="01xxxxxxxxx">
  </div>
	<div class="form-group">
    <label for="inputAge">Age</label>
    <input type="text" class="form-control" runat="server" id="inputAge" placeholder="Input Age">
		<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="inputAge" Operator="DataTypeCheck" Type="Integer" Display="Dynamic" ErrorMessage="Invalid Input" ForeColor="Red"></asp:CompareValidator>
  </div>
	<div class="form-group">
    <label for="inputAddress">Address</label>
    <input type="text" runat="server" class="form-control" id="inputAddress" placeholder="Address">
  </div>
	<asp:Button ID="saveButton" runat="server" class="btn btn-primary" Text="Save" OnClick="saveButton_Click" />
	<br />
	<asp:Label ID="successMessageLabel" runat="server" ></asp:Label>
	<br />
	<asp:GridView ID="studentGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
		<AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
		<EditRowStyle BackColor="#999999" />
		<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
		<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
		<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
		<RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
		<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
		<SortedAscendingCellStyle BackColor="#E9E7E2" />
		<SortedAscendingHeaderStyle BackColor="#506C8C" />
		<SortedDescendingCellStyle BackColor="#FFFDF8" />
		<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
	</asp:GridView>
	<br />

</asp:Content>
