<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Services.aspx.cs" Inherits="Services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style>
    .service h4{
        color:Green;
        font:Arial ;
        text-align:center;
        
    }
    .service table{
         align:center;
         text-align:center; 
         margin:30px auto 20px auto ;  
         border-radius: 50px;
        
    }
    .service table tr td{
        color:red;
        font:Arial ;
        text-align:center;
        padding:50px;
        font-size:x-large;
        
    }    
</style>


<div class="service">
<h4> Services </h4>
<table>
    <tbody>
     <tr>
        <td>Dilivery and Pickup</td>
        <td>Dry cleaning</td>
     </tr>
    </tbody>
</table>
</div>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

