<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListUI.aspx.cs" Inherits="WebClassApp.StudentListUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">Student Information Management</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style10">First Name:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="firstNameTextBox" runat="server" Height="21px"  Width="219px"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Last Name:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="lastNameTextBox" runat="server" Width="218px" ></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">User Name: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="userNameTextBox" runat="server" Height="21px" Width="219px"></asp:TextBox>
                        </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Reg. No.:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="regNoTextBox" runat="server" Height="23px" Width="215px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style9">Email: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="214px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Age: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="ageTextBox" runat="server" Height="28px" Width="210px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style11">
                     <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td class="auto-style11">
                     <asp:ListBox ID="ListBox1" runat="server" Height="229px" Width="230px"></asp:ListBox>
                 </td>
                 <td>&nbsp;</td>
             </tr>
        </div>
    </form>
            
        </body>
</html>
