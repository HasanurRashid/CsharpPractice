<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Queue.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="font-family:Arial; border: 1px solid;text-align:center">

         <tr>
             <td><b>Customr 1</b></td>
             <td></td>
             <td><b>Customr 2</b></td>
             <td></td>
             <td><b>Customr 3</b></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="txtbox1" runat="server" Width="125px" Font-Size="Large" BackColor="#3366FF" ForeColor="White"></asp:TextBox>
             </td>
             <td></td>
             <td>
                 <asp:TextBox ID="txtbox2" runat="server" Width="125px" Font-Size="Large" BackColor="#3366FF" ForeColor="White"></asp:TextBox>
             </td>
             <td></td>
             <td>
                 <asp:TextBox ID="txtbox3" runat="server" Width="125px" Font-Size="Large" BackColor="#3366FF" ForeColor="White"> </asp:TextBox>
             </td>
         </tr>

          <tr>
             <td>
                  <asp:Button ID="Button1" runat="server" Text="Next" Width="150px" OnClick="Button1_Click" />
             </td>
             
             <td></td>
             <td>
                 <asp:Button ID="Button2" runat="server" Text="Next" Width="150px" OnClick="Button2_Click" />
             </td>
             <td></td>
             <td>
                 <asp:Button ID="Button3" runat="server" Text="Next" Width="150px" OnClick="Button3_Click" />
             </td>
         </tr>

         <tr>
             <td colspan="5">
                 <asp:TextBox ID="txtDisplay" runat="server" Width="500px" Font-Size="Large" BackColor="#006600" ForeColor="#ffffff"></asp:TextBox>
             </td>
             
         </tr>
         <tr>
             <td colspan="5" style="text-align:center">
                 <asp:ListBox ID="tokenList" runat="server" Width="500px"></asp:ListBox>
             </td>
            
         </tr>
         <tr>
             <td colspan="5" style="text-align:center">
                  <asp:Button ID="btnPrint" runat="server" Text="Print Token" Width="125px" OnClick="btnPrint_Click" />
             </td>
             
         </tr>
         <tr>
             <td colspan="5" style="text-align:center">
                 <asp:Label ID="lblMessage" runat="server" Text="" Width="500px" BackColor="#669999" ForeColor="#009933"></asp:Label>
             </td>
            
         </tr>

     </table>
    </form>
</body>
</html>
