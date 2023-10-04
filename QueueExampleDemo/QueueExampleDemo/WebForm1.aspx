<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueueExampleDemo.WebForm1" %>

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
             <asp:TextBox ID="txtCounter1" runat="server" BackColor="#3366FF" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox>
         </td>
         <td></td>
         <td>
              <asp:TextBox ID="txtCounter2" runat="server" BackColor="#3366FF" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox>
         </td>
         <td></td>
         <td>
              <asp:TextBox ID="txtCounter3" runat="server" BackColor="#3366FF" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox>
         </td>
     </tr>
    <tr>
         <td>
            <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" OnClick="btnCounter1_Click" />
         </td>
         <td></td>
         <td>
               <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" OnClick="btnCounter2_Click" />
         </td>
         <td></td>
         <td>
               <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" OnClick="btnCounter3_Click" />
         </td>
     </tr>
     <tr>
         <td colspan="5">
             <asp:TextBox ID="txtDisplay" runat="server" Width="500px" Font-Size="Large" BackColor="#339933" ForeColor="#ffffcc"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td colspan="5">
             <asp:ListBox ID="listTokens" Font-Size="Large" runat="server" Width="100px"></asp:ListBox>
         </td>
     </tr>
     <tr>
         <td colspan="5">
             <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" OnClick="btnPrintToken_Click" />
         </td>
     </tr>
     <tr>
         <td colspan="5">
             <asp:Label ID="lblStatus" runat="server" font-size="Large"></asp:Label>
         </td>
     </tr>
 </table>
    </form>
</body>
</html>
