<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoUI.aspx.cs" Inherits="WebClassApp.StudentInfoUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 310px;
        }
        .auto-style2 {
            width: 213px;
        }
        .auto-style4 {
            width: 213px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 310px;
            height: 21px;
        }
        .auto-style7 {
            width: 213px;
            height: 21px;
        }
        .auto-style8 {
            height: 21px;
        }
        .auto-style9 {
            width: 310px;
            text-align: right;
        }
        .auto-style10 {
            width: 310px;
            height: 23px;
            text-align: right;
        }
        .auto-style11 {
            width: 213px;
            text-align: left;
        }
        .auto-style12 {
            width: 213px;
            text-align: right;
        }
        .auto-style13 {
            width: 213px;
            height: 23px;
            text-align: right;
        }
    </style>
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
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">First Name: </td>
                    <td class="auto-style12">
                        <asp:Label ID="firstNameLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Last Name</td>
                    <td class="auto-style12">
                        <asp:Label ID="lastNameLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">User Name: </td>
                    <td class="auto-style13">
                        <asp:Label ID="userNameLabel" runat="server" Text="Label"></asp:Label>
                        
                        </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Reg. No.:</td>
                    <td class="auto-style12">
                        <asp:Label ID="regNoLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Email: </td>
                    <td class="auto-style12">
                        <asp:Label ID="emailLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Age: </td>
                    <td class="auto-style12">
                        <asp:Label ID="agelabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="messageLabel" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">FullName:</td>
                    <td class="auto-style2">
                        <asp:Label ID="fullNameLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="studentListButton" runat="server" Text="Student List" OnClick="studentListButton_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
