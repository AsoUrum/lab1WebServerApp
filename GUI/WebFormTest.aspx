
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTest.aspx.cs" Inherits="Lab1_ASP.NetConnectedMode.GUI.WebFormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1:Database Programming in connected Mode</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 89px;
            left: 469px;
            z-index: 1;
            height: 28px;
        }
        .auto-style2 {
            position: absolute;
            top: 183px;
            left: 520px;
            z-index: 1;
            width: 109px;
        }
        .auto-style3 {
            position: absolute;
            top: 227px;
            left: 562px;
            z-index: 1;
            height: 32px;
        }
        .auto-style4 {
            width: 857px;
            height: 424px;
            position: absolute;
            top: 15px;
            left: 10px;
        }
        .auto-style5 {
            width: 454px;
            height: 133px;
            position: absolute;
            top: 242px;
            left: 85px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 138px;
            left: 483px;
            z-index: 1;
            height: 35px;
            width: 109px;
        }
        .auto-style7 {
            position: absolute;
            top: 136px;
            left: 666px;
            z-index: 1;
            bottom: 262px;
        }
    </style>
</head>
<body style="height: 413px">
    <form id="form1" runat="server" class="auto-style4" style="z-index: 1">
        <div>
        </div>
        <p>

            <asp:Label ID="lblEmployeeId" runat="server" style="position: absolute; z-index: 1; left: 163px; top: 88px; height: 26px; width: 97px; bottom: 272px" Text="EmployeeId :"></asp:Label>
            <asp:TextBox ID="tbEmployeeId" runat="server" style="z-index: 1; left: 282px; top: 91px; position: absolute; height: 21px"></asp:TextBox>


            <asp:Button ID="btnSave" runat="server" CssClass="auto-style1" OnClick="btnSave_Click" Text="Save Employee" />


        </p>
        <p>
            &nbsp;<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 162px; top: 130px; position: absolute; height: 19px; width: 101px" Text="First Name :"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="tbFirstName" runat="server" style="z-index: 1; left: 283px; top: 127px; position: absolute; height: 19px"></asp:TextBox>


            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 163px; top: 167px; position: absolute; width: 90px" Text="Last Name :"></asp:Label>
            <asp:Button ID="btnUpdate" runat="server" CssClass="auto-style6" OnClick="btnUpdate_Click" Text="update" />
            <asp:Button ID="btnDelete" runat="server" CssClass="auto-style7" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <asp:TextBox ID="tbLastName" runat="server" style="z-index: 1; left: 281px; top: 168px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblJobTitle" runat="server" style="z-index: 1; left: 164px; top: 203px; position: absolute; width: 69px" Text="Job Title :"></asp:Label>
        <asp:TextBox ID="tbJobTitle" runat="server" style="z-index: 1; left: 281px; top: 201px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>

    <asp:Button ID="Button1" runat="server" Text="ButtonTest" OnClick="Button1_Click" style="z-index: 1; left: 149px; top: 246px; position: relative; width: 103px; height: 44px" />


        <asp:Button ID="btnSearch" runat="server" CssClass="auto-style2" OnClick="btnSearch_Click" Text="Search Record" />


        <asp:GridView ID="GridViewEmployee" runat="server" CssClass="auto-style5" Width="454px">
        </asp:GridView>
        <p>
            <asp:Button ID="btnListAll" runat="server" CssClass="auto-style3" OnClick="btnListAll_Click" Text="List All Employee" />
        </p>


    </form>

    
</body>
</html>
