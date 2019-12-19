<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style>
.login {
            margin:100px 400px 100px 400px;
            
            background:tranparent;
  
        }
        .login h4{
             margin-top:40px;
             text-align:center;
             color:Green;
             font-size:30px;
        }
        .login table{
             align:center;
             text-align:center; 
             margin:30px auto 20px auto ;  
             border-radius: 50px;
        }
        
        .login table tr td{
             color:red;
             vertical-align:top;
	         padding:0px;
	         font-size:20px;
	       
        }
        .t1{
             height:40px;
	         width:300px;
	         line-height:26px;
	         margin:0;
	         padding:2px;
             display:inline-block;
             border-radius:20px;         
        }
        .b1{
            background-color:red;
	        color:#ffffff;
	        cursor:pointer;
	        border:1;
	        margin:;
	        padding:8px 20px;
         }
        .b1:hover {
           color:#ff7800;
         }
         .reg
         {
             color:Purple;
             text-align:center;
             }
      

    </style>









<div class="login">
        <h4>Registration:</h4> 


        <asp:Label ID="Label1" runat="server" Text="Label " align="center" color="red"></asp:Label>
        <table class="tt">
        
            
        <tr>
          <td><asp:TextBox  CssClass="t1" ID ="TextBox1" runat="server" placeholder="First Name   Last Name*"   required ></asp:TextBox></td>
          <td><asp:TextBox CssClass="t1" ID="TextBox2" runat="server" placeholder="Set Username*" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
         ControlToValidate="TextBox1" ErrorMessage="Enter Valid Name"                       
         ValidationExpression="[a-zA-Z ]*$"></asp:RegularExpressionValidator></td>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="TextBox2" ErrorMessage="Please Enter Valid Username" 
          ValidationExpression="[A-Za-z][A-Za-z0-9._]{5,14}" ></asp:RegularExpressionValidator></td>
        </tr>


        
        <tr>
           <td><asp:TextBox CssClass="t1" ID="TextBox3" runat="server" placeholder="Password*" TextMode="Password" required></asp:TextBox></td>
           <td><asp:TextBox CssClass="t1" ID="TextBox4" runat="server" placeholder=" Confirm Password*" TextMode="Password" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="TextBox3" ErrorMessage="Enter Valid Password" 
          ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$" ></asp:RegularExpressionValidator></td>
          <td><asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToValidate="TextBox4"
             ControlToCompare="TextBox3" ErrorMessage="Password must be the same"  /></td>
        </tr>
        
        
        <tr>
          <td><asp:TextBox CssClass="t1" ID="TextBox5" runat="server" placeholder="Email*" required></asp:TextBox></td>
          <td><asp:TextBox CssClass="t1" ID="TextBox6" runat="server" placeholder="Birthdate  DD/MM/YYYY*"   required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
          ControlToValidate="TextBox5" ErrorMessage="Please Enter Valid Email" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
          <td><asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
          ControlToValidate="TextBox6" ErrorMessage="Please Enter Valid Date" 
          ValidationExpression="\d{1,2}/\d{1,2}/\d{4}"></asp:RegularExpressionValidator></td>
        </tr>

        

        <tr>
          <td> <asp:DropDownList CssClass="t1"  ID="Gender" runat="server">
            <asp:ListItem Enabled="true" Text="Select Gender" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem> </asp:DropDownList>  </td>
            <td><asp:TextBox CssClass="t1" ID="TextBox8" runat="server"  placeholder="Address*" required></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:RequiredFieldValidator ID="ReqMonth" runat="server" ControlToValidate="Gender" ErrorMessage="Please select Gender" InitialValue="-1"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
         ControlToValidate="TextBox8" ErrorMessage="Enter Valid Text" 
         ValidationExpression="[A-Z]*[a-z]*"></asp:RegularExpressionValidator></td>
        </tr>
        
        </table>
        <table>
         <tr><td><asp:Button CssClass="b1"  ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" /></td></tr>
         <tr><td><a  href="Userlogin.aspx" > Already Register?<u>Login</u></a></td></tr>
       </table>
    </div>

    
    

</asp:Content>

