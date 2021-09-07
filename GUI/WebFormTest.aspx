
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTest.aspx.cs" Inherits="Lab1_ASP.NetConnectedMode.GUI.WebFormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1:Database Programming in connected Mode</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>

            <asp:Label ID="lblEmployeeId" runat="server" style="position: absolute; z-index: 1; left: 163px; top: 88px; height: 26px; width: 97px; bottom: 272px" Text="EmployeeId :"></asp:Label>
            <asp:TextBox ID="tbEmployeeId" runat="server" style="z-index: 1; left: 282px; top: 91px; position: absolute; height: 21px"></asp:TextBox>


        </p>
        <p>
            &nbsp;<asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 162px; top: 130px; position: absolute; height: 19px; width: 101px" Text="First Name :"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="tbFirstName" runat="server" style="z-index: 1; left: 283px; top: 127px; position: absolute; height: 19px"></asp:TextBox>


            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 163px; top: 167px; position: absolute; width: 90px" Text="Last Name :"></asp:Label>
        </p>
        <asp:TextBox ID="tbLastName" runat="server" style="z-index: 1; left: 281px; top: 168px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblJobTitle" runat="server" style="z-index: 1; left: 164px; top: 203px; position: absolute; width: 69px" Text="Job Title :"></asp:Label>
        <asp:TextBox ID="tbJobTitle" runat="server" style="z-index: 1; left: 281px; top: 201px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>

    <asp:Button ID="Button1" runat="server" Text="ButtonTest" OnClick="Button1_Click" style="z-index: 1; left: 149px; top: 246px; position: relative; width: 103px; height: 44px" />


    </form>

    
</body>
</html>
