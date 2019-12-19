
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style9
    {
        height: 32px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style6" style="height: 138px; width: 108%" bgcolor="#EDDCD1">
    <tr>
        <td>
            User id</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Password</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Type</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="126px">
                <asp:ListItem>--select--</asp:ListItem>
                <asp:ListItem>user</asp:ListItem>
                <asp:ListItem>admin</asp:ListItem>
                <asp:ListItem>servicemen</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style9">
            <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
                BorderColor="#745A9E" />
            If you want to register click<asp:Button ID="Button2" runat="server" 
                onclick="Button2_Click" Text="REGISTRATION" Width="107px" />
        </td>
    </tr>
</table>
</asp:Content>

