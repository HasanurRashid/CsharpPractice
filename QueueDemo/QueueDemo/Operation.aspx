<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operation.aspx.cs" Inherits="QueueDemo.Operation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="font-family:Arial;text-align:center;font-size:large;border:1px solid" >
        <tr>
            <td>Customer 1</td>
            <td></td>
            <td>Customer 2</td>
            <td></td>
            <td>Customer 3</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtCounter1" runat="server" Width="150px" Font-Size="Large" ForeColor="#ffffff" BackColor="#000000"></asp:TextBox>
            </td>
            <td></td>
            <td>
                  <asp:TextBox ID="txtCounter2" runat="server" Width="150px" Font-Size="Large" ForeColor="#ffffff" BackColor="#000000"></asp:TextBox>
            </td>
            <td></td>
            
            <td>
                  <asp:TextBox ID="txtCounter3" runat="server" Width="150px" Font-Size="Large" ForeColor="#ffffff" BackColor="#000000"></asp:TextBox>
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
                <asp:TextBox ID="txtDisplay" runat="server" Width="500px" Font-Size="Large" ForeColor="#ffffff" BackColor="#000000"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:ListBox ID="tokenList" runat="server" Font-Size="Large" Width="200px"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="btnPrint" runat="server" Text="Print Token" Width="150px" OnClick="btnPrint_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Label ID="lblStatus" runat="server" Text="" BackColor="#339933" ForeColor="#ffffff" Font-Size="Large"></asp:Label>
            </td>
        </tr>

    </table>
    </form>
</body>
</html>
