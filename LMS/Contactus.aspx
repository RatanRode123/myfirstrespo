<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contactus.aspx.cs" Inherits="Contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style>
        .login {
            margin:100px 400px 100px 400px;
            border-radius:200px 200px 200px 200px;
            background:#00bfff;
  
        }
        .login h4{
             margin-top:40px;
             text-align:center;
             color:Green;
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
        }
        .t1{
             height:30px;
	         width:250px;
	         line-height:26px;
	         margin:0;
	         padding:2px;
             display:inline-block;
             border-radius:20px;         
        }
        .t2{
             height:100px;
	         width:250px;
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
      

    </style>

    <div class="login">
        <h4>Contact Us:</h4> 
        <table >
        
        
        <tr>
          <td><asp:TextBox  CssClass="t1" ID ="TextBox1" runat="server" placeholder="First Name  Last Name" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="TextBox1" ErrorMessage="Please Enter Valid Username" 
          ValidationExpression="[A-Z]*[a-z]*" ></asp:RegularExpressionValidator></td>
        </tr>

        
        
        <tr>
          <td><asp:TextBox CssClass="t1" ID="TextBox2" runat="server" placeholder="Email" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
          ControlToValidate="TextBox2" ErrorMessage="Please Enter Valid Email" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr>



        <tr>
          <td><asp:TextBox CssClass="t1" ID="TextBox3" runat="server" placeholder="Mobile Number"  required></asp:TextBox></td>
        </tr>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
         ControlToValidate="TextBox3" ErrorMessage="Enter Valid Mobile Number" 
         ValidationExpression="[0-9]*"></asp:RegularExpressionValidator></td>
        </tr>


        
        
        <tr>
          <td><asp:TextBox CssClass="t2" ID="TextBox4" runat="server" placeholder="Message" TextMode="Multiline" required></asp:TextBox></td>
        </tr>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
         ControlToValidate="TextBox4" ErrorMessage="Enter Valid Text" 
         ValidationExpression="[A-Z]*[a-z]*"></asp:RegularExpressionValidator></td>
        </tr>

        
        
        <tr>
           <td> <asp:Button CssClass="b1"  ID="Button1" runat="server" Text="Send Message" /></td>
        </tr>
        
        
        </table>

    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

