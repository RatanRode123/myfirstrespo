<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="adminview status.aspx.cs" Inherits="adminview_status" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CC9966" 
        BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="318px" 
        Width="940px">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <RowStyle BackColor="White" ForeColor="#330099" />
    <Columns>
        <asp:BoundField DataField="servid" HeaderText="servid" 
            SortExpression="servid" />
        <asp:BoundField DataField="userid" HeaderText="userid" 
            SortExpression="userid" />
        <asp:BoundField DataField="complaint" HeaderText="complaint" 
            SortExpression="complaint" />
        <asp:BoundField DataField="status" HeaderText="status" 
            SortExpression="status" />
    </Columns>
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ccsConnectionString2 %>" 
    SelectCommand="SELECT * FROM [tblstatus]"></asp:SqlDataSource>
<br />
<br />
</asp:Content>

