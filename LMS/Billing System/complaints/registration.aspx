<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table class="style6">
            <tr>
                <td>
                    User id</td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" Width="175px" 
                                                ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ErrorMessage="Enter valid Id" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            User name</td>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server" Width="175px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Uassword</td>
                                        <td>
                                            <asp:TextBox ID="TextBox3" runat="server" Width="175px" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Confrm password</td>
                                        <td>
                                            <asp:TextBox ID="TextBox4" runat="server" Width="175px" TextMode="Password"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToCompare="TextBox3" ControlToValidate="TextBox4" 
                                                ErrorMessage="Password  didnot match"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Email id</td>
                                        <td>
                                            <asp:TextBox ID="TextBox5" runat="server" Width="175px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="enter a valid E-mail ID" 
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Phone no</td>
                                        <td>
                                            <asp:TextBox ID="TextBox6" runat="server" Width="175px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                ErrorMessage="Enter  phone number" ValidationExpression="\d{10,12}" 
                                                ControlToValidate="TextBox6"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Address</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>

