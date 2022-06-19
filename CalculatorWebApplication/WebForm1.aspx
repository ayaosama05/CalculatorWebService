<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 105px;
            width: 244px;
        }
        .auto-style4 {
            width: 244px;
        }
        .auto-style5 {
            width: 219px;
        }
        .auto-style6 {
            height: 105px;
            width: 219px;
        }
        .auto-style7 {
            margin-left: 6px;
        }
        .auto-style8 {
            margin-left: 14px;
        }
        .auto-style9 {
            width: 485px;
        }
    </style>
</head>
<body style="height: 199px">
    <form id="form1" runat="server">
        <table class="auto-style9">
            <tr>
                <td class="auto-style5"><strong>First Number</strong></td>
                <td class="auto-style4">
                    <asp:TextBox ID="FirstNumTxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td class="auto-style5"><strong>Second Number</strong></td>
                <td class="auto-style4">
                    <asp:TextBox ID="SecondNumTxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Result :</strong></td>
                <td class="auto-style1">
                    <asp:Label ID="ResultLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="AddBtn" runat="server" Text="Add (+)" OnClick="AddBtn_Click" />
                    <asp:Button ID="SubtractBtn" runat="server" Text="Subtract (-)" OnClick="SubtractBtn_Click" CssClass="auto-style7" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="MultiplyBtn" runat="server" Text="Multiply (x)" OnClick="MultiplyBtn_Click" Width="113px" />
                    <asp:Button ID="DivideBtn" runat="server" Text="Divide (÷)" OnClick="DivideBtn_Click" CssClass="auto-style8" Width="115px" />
                </td>
            </tr>
        </table>
         <asp:GridView ID="CalculationsGV" runat="server" Width="565px"></asp:GridView>
    </form>
</body>
</html>
