<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDataEnrty.aspx.cs" Inherits="CustomerDataEntryWeb2.CustomerDataEnrty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="CustomerDataEntryWeb" runat="server">
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtcustName" runat="server" style="margin-left: 79px" Width="159px">Enter Name</asp:TextBox>
        <br />
        <div>
            <asp:Label ID="lblCountryName" runat="server" Text="Country Name"></asp:Label>
            <asp:DropDownList ID="ddlCountry" runat="server" style="margin-left: 94px">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>Srilanka</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>Bangladesh</asp:ListItem>
                <asp:ListItem>Pakistan</asp:ListItem>
                <asp:ListItem>Malasia</asp:ListItem>
                <asp:ListItem>Japan</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem>Korea</asp:ListItem>
                <asp:ListItem>Russia</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:CheckBox ID="Male" runat="server" Text="Male" />
            <asp:CheckBox ID="Female" runat="server" Text="Female" />
        </div>
        <p>
            <asp:CheckBox ID="Painting" runat="server" Text="Painting" />
            <asp:CheckBox ID="Reading" runat="server" Text="Reading" />
        </p>
        <p>
            <asp:RadioButton ID="Married" runat="server" GroupName="Status" Text="Married" />
            <asp:RadioButton ID="Single" runat="server" GroupName="Status" Text="Single" />
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 44px" Width="159px"></asp:TextBox>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="73px" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" style="margin-left: 58px" Text="Update" Width="93px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 64px" Text="Delete" />
        <br />
        <asp:GridView ID="GridCustomers" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridCustomers_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
