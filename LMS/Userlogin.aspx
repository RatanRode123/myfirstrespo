<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Userlogin.aspx.cs" Inherits="Userlogin" %>

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
        <h4>Customer Login:</h4> 
        <div class="reg">
            <h4> <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h4>
        </div>

        <table >
        
        
        <tr>
          <td><asp:TextBox  CssClass="t1" ID ="TextBox1" runat="server" placeholder="Username*" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="TextBox1" ErrorMessage="Please Enter Valid Username" 
          ValidationExpression="[A-Za-z][A-Za-z0-9._]{5,14}" ></asp:RegularExpressionValidator></td>
        </tr>

        
        
        <tr>
          <td><asp:TextBox CssClass="t1" ID="TextBox2" runat="server" placeholder="Password*" TextMode="Password" required></asp:TextBox></td>
        </tr>
        <tr>
         <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ControlToValidate="TextBox2" ErrorMessage="Enter Valid Password" 
          ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$" ></asp:RegularExpressionValidator></td>
        </tr>




        <tr>
           <td> <a href="Adminprofile.aspx"><asp:Button CssClass="b1"  ID="Button1" 
                   runat="server" Text="SignUp" onclick="Button1_Click" /></a></td>
        </tr>
        
        <tr>
           <td> <a  href="Register.aspx" > If Not Register</a> </td>
        </tr>
        </table>


    </div>


</asp:Content>

