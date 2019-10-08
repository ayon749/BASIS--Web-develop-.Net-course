<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="name.aspx.cs" Inherits="fullname.name" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label1" runat="server" Text="Enter Your Name: "></asp:Label>
        </div>
		<br />
		  <div>
			<asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label>
			  <asp:TextBox ID="fNameTextBox" runat="server"></asp:TextBox>
        </div>
		<br />
		  <div>
			<asp:Label ID="Label3" runat="server" Text="Middle Name: "></asp:Label>
			   <asp:TextBox ID="mNameTextBox" runat="server"></asp:TextBox>
        </div>
		<br />
		  <div>
			<asp:Label ID="Label4" runat="server" Text="Last Name: "></asp:Label>
			   <asp:TextBox ID="lNameTextBox" runat="server"></asp:TextBox>
        </div>
		<br />
			  <div>
				  <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        </div>
		<br />

		<div>
			<asp:Label ID="Label5" runat="server" Text="Your Full Name is: "></asp:Label>
			<asp:Label ID="fullNameLabel" runat="server" ></asp:Label>
		</div>
    </form>
</body>
</html>
