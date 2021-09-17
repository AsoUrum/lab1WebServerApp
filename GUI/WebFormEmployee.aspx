<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_ASP.NetConnectedMode.GUI.WebFormEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 828px;
        }
        .auto-style2 {
            height: 71px;
            text-align: center;
        }
        .auto-style8 {
            width: 207px;
        }
        .auto-style9 {
            position: absolute;
            top: 33px;
            left: 225px;
            z-index: 1;
            font-size: x-large;
            letter-spacing: 3px;
            font-family: "Arial Black";
        }
        .auto-style10 {
            width: 148px;
            height: 42px;
        }
        .auto-style11 {
            width: 207px;
            height: 42px;
        }
        .auto-style12 {
            width: 148px;
            height: 39px;
        }
        .auto-style13 {
            width: 207px;
            height: 39px;
        }
        .auto-style17 {
            width: 166px;
            height: 42px;
            text-align: right;
        }
        .auto-style19 {
            width: 166px;
            height: 39px;
            text-align: right;
        }
        .auto-style20 {
            width: 166px;
        }
        .auto-style21 {
            width: 148px;
        }
        .auto-style22 {
            width: 166px;
            height: 21px;
            text-align: right;
        }
        .auto-style23 {
            width: 148px;
            height: 21px;
        }
        .auto-style24 {
            width: 207px;
            height: 21px;
        }
        .auto-style29 {
            width: 166px;
            height: 23px;
        }
        .auto-style30 {
            width: 148px;
            height: 23px;
        }
        .auto-style32 {
            width: 207px;
            height: 23px;
        }
        .auto-style33 {
            width: 152px;
            height: 42px;
        }
        .auto-style34 {
            width: 152px;
            height: 39px;
        }
        .auto-style35 {
            width: 152px;
            height: 23px;
        }
        .auto-style36 {
            width: 152px;
            height: 21px;
        }
        .auto-style37 {
            width: 152px;
        }
        .auto-style38 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4">
                    <asp:Label ID="LblTitle" runat="server" BackColor="White" CssClass="auto-style9" Font-Bold="True" Font-Size="Larger" ForeColor="#FF9900" Text="Employee Maintenance"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtEmployeeId" runat="server" Width="151px"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="120px" OnClick="btnSave_Click" />
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtFirstName" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="120px" OnClick="btnUpdate_Click" />
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtLastName" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style34">
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="120px" OnClick="btnDelete_Click" />
                </td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Label ID="lblJobTitle" runat="server" Text="Job Title"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtJobTitle" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:Button ID="btnListAll" runat="server" Text="List All" Width="120px" OnClick="btnListAll_Click" />
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style29"></td>
                <td class="auto-style30"></td>
                <td class="auto-style35"></td>
                <td class="auto-style32"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="lblSearchby" runat="server" Text="Search By"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="dpdListSeearchBy" runat="server" Width="150px" CssClass="auto-style38">
                        <asp:ListItem>EmployeeId</asp:ListItem>
                        <asp:ListItem>First Name</asp:ListItem>
                        <asp:ListItem>Last Name</asp:ListItem>
                        <asp:ListItem>JobTitle</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style36">
                    <asp:TextBox ID="txtSearchBy" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" Width="93px" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblEmployeeListTitle" runat="server" Enabled="False" Font-Bold="True" Font-Size="Large" ForeColor="#3366FF" Text="Employee List"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="gviewListAllEmployee" runat="server" Width="568px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
