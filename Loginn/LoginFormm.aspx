<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFormm.aspx.cs" Inherits="Loginn.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
      <style>
        .center-text {
        text-align: center;
    }

    .vertical-top {
        vertical-align: top;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <table class="auto-style1"> 
    <tr>
        <td colspan="6" class="center-text vertical-top">
            <asp:Label ID="Label1" runat="server" Text="Login" Font-Bold="False" BackColor="#CCCCCC"></asp:Label>
        </td>
    </tr>

    
        <tr>
            <td></td>
            <td class="center-text">
                <asp:Label ID="Label2" runat="server" Text="Username" BackColor="#999999"></asp:Label>
            </td>
            <td class="center-text">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
               <tr>
    <td></td>
    <td class="center-text">
        <asp:Label ID="Label3" runat="server" Text="Password" BackColor="#999999"></asp:Label>
    </td>
    <td class="center-text">
         <%-- Set the TextMode property to Password for the password TextBox --%>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    <td></td>
    <td></td>
    <td></td>
</tr>
<tr>
        <td></td>
        <td></td>
        <td class="center-text">
            <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Login" BackColor="#3366CC" />
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
              

            </table>
         </div>
        
    </form>
</body>
</html>
     