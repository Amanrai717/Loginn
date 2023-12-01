<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Loginn.Form1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registraion Form</title>
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
             <asp:Label ID="Label4" runat="server" Text="Registration" BackColor="#999999"></asp:Label>
            </td>
</tr>


    <tr>
        <td></td>
        <td class="center-text">
             <asp:Label ID="Label5" runat="server" Text="Username" BackColor="#999999"></asp:Label>
              </td>
  <td class="center-text">
      <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
           <tr>
<td></td>
<td class="center-text">
    <asp:Label ID="Label6" runat="server" Text="Password" BackColor="#999999"></asp:Label>
        </td>
    <td class="center-text">
        
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    <td></td>
    <td></td>
    <td></td>
</tr>
<tr>
        <td></td>
        <td></td>
        <td class="center-text">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" BackColor="#3366CC" />
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
