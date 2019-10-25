<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentInformationUI.aspx.cs" Inherits="InformationManagementApp.StudentInformationUI" %>
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
	<asp:Button ID="updateButton" runat="server" class="btn btn-warning" Text="Update" OnClick="updateButton_Click"  />
	 <asp:Button ID="deleteButton" class="btn btn-danger" runat="server" Text="Delete" OnClick="deleteButton_Click"  />

	<br />
	<asp:Label ID="successMessageLabel" runat="server" ></asp:Label>
	<br />
	
</asp:Content>
