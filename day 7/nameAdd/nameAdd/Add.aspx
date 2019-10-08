<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="nameAdd.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label1" runat="server" Text="Enter a name"></asp:Label>
			<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </div>
		<br />
		<div >
			<asp:Button ID="showButton" runat="server" Text="show" OnClick="showButton_Click"  />
			<asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
		</div>
		<br />
		<div>
			<asp:Label ID="shownName" runat="server" ></asp:Label>
		</div>
    </form>
</body>
</html>
