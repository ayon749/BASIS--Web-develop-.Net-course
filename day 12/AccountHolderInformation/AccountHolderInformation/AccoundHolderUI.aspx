<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccoundHolderUI.aspx.cs" Inherits="AccountHolderInformation.AccoundHolderUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 228px;
        }
        .auto-style5 {
            text-align: right;
            width: 190px;
        }
        .auto-style7 {
            width: 190px;
        }
        .auto-style8 {
            width: 228px;
            height: 26px;
        }
        .auto-style9 {
            width: 190px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style15 {
            height: 23px;
            width: 228px;
        }
        .auto-style16 {
            height: 23px;
            width: 194px;
        }
        .auto-style18 {
            height: 23px;
            width: 194px;
            text-align: right;
        }
        .auto-style19 {
            height: 23px;
            width: 644px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Account Creation">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style8">Account Numeber</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="accountNumbertextBox" runat="server" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style10"></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Account Name</td>
                        <td class="auto-style7">
                            <asp:TextBox ID="accountNameTextBox" runat="server" Width="182px" ></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" GroupingText="Transaction">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style15">Amount</td>
                        <td class="auto-style16">
                            <asp:TextBox ID="amounttextBox" runat="server" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style19"></td>
                    </tr>
                    <tr>
                        <td class="auto-style15"></td>
                        <td class="auto-style18">
                            <asp:Button ID="depositButton" runat="server" Text="Deposit" OnClick="depositButton_Click" />
                            <asp:Button ID="withdrawButton" runat="server" Text="Withdraw" OnClick="withdrawButton_Click" />
                        </td>
                        <td class="auto-style19"></td>
                    </tr>
                   
                </table>
            </asp:Panel>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="reportButton" runat="server" Text="Report" Width="1040px" OnClick="reportButton_Click" />
        </div>
        <asp:Label ID="showReportLabel" runat="server" ></asp:Label>
    </form>
</body>
</html>
