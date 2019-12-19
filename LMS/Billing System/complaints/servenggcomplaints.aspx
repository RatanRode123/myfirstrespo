<%@ Page Language="C#" MasterPageFile="~/serviceengg.master" AutoEventWireup="true" CodeFile="servenggcomplaints.aspx.cs" Inherits="servenggcomplaints" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" 
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" GridLines="Horizontal" 
            Height="195px" Width="944px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <PagerStyle ForeColor="#4A3C8C" HorizontalAlign="Right" BackColor="#E7E7FF" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
        <asp:Image ID="Image2" runat="server" Height="168px" 
            ImageUrl="~/images/work.jpg" Width="255px" />
    <table class="style1">
        <tr>
            <td>
                Servid</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Complaint</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                status</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="176px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Status" />
            </td>
        </tr>
    </table>
    <br />
</p>
<p>
</p>
</asp:Content>

