<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VehicleInformationUI.aspx.cs" Inherits="VehicleInformationSystem.VehicleInformationUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="form-group">
    <label for="inputCarModel">Car Model</label>
    <input type="text" class="form-control" id="inputCarModel" runat="server" placeholder="Car Model">
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="inputCarModel" Display="Dynamic" runat="server" ErrorMessage="Car Model can not  be empty" ForeColor="Red"></asp:RequiredFieldValidator>
  </div>
	<div class="form-group">
    <label for="inputRegNo">Reg No</label>
    <input type="text" class="form-control" runat="server" id="inputRegNo" placeholder="Reg No.">
  </div>
	<div class="form-group">
    <label for="inputOwnerName">Owner Name</label>
    <input type="text" class="form-control" runat="server" id="inputOwnerName" placeholder="Owner Name">
  </div>
	<div class="form-group">
    <label for="inputRegDate">Reg Date</label>
    <input type="date" class="form-control" id="inputRegDate" runat="server" placeholder="Date">
  </div>
	<div class="form-group">
    <label for="inputColor">Color</label>
    <input type="text" class="form-control" runat="server" id="inputColor" placeholder="Color">
  </div>
	<asp:Button ID="saveButton" runat="server" Text="Save" />
	<br />
	<asp:Label ID="showMessage" runat="server" ></asp:Label>
</asp:Content>
