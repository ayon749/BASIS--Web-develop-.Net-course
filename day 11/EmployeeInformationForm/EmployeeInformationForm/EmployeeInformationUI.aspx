<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeInformationUI.aspx.cs" Inherits="EmployeeInformationForm.EmployeeInformationUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="form-group">
    <label for="inputEmployeeName">Employee Name</label>
    <input type="text" class="form-control" runat="server" id="inputEmployeeName" placeholder="Enter Name">
	 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputEmployeeName" ErrorMessage="Name field can not be empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
  </div>
	 <div class="form-group">
    <label for="inputPosition">Position</label>
    <input type="text" class="form-control" runat="server" id="inputPosition" placeholder="Enter Position">
  </div>
	 <div class="form-group">
    <label for="inputMobileNo">Mobile No</label>
    <input type="text" class="form-control" runat="server" id="inputMobileNo" placeholder="01XXXXXXXXX">
  </div>
	 <div class="form-group">
    <label for="inputEmailAddress">Email Address</label>
    <input type="email" class="form-control" runat="server" id="inputEmailAddress" placeholder="Enter Email">
  </div>
	 <div class="form-group">
    <label for="inputSalary">Salary</label>
    <input type="text" class="form-control" runat="server" id="inputSalary" placeholder="Enter Salary">
  </div>
	<div class="form-group">
    <label for="inputAge">Age</label>
    <input type="text" class="form-control" runat="server" id="inputAge" placeholder="Enter Age">
		<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="inputAge" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Display="Dynamic" ErrorMessage="Invalid input"></asp:CompareValidator>
  </div>
	<div class="form-group">
    <label for="inputAddress">Address</label>
    <input type="text" class="form-control" runat="server" id="inputAddress" placeholder="Enter Address">
  </div>
	<asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
	<br />
	<asp:Label ID="showMessage" runat="server" ></asp:Label>

</asp:Content>
