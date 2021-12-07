<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="InventoryWebService.Salesman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="margin: 0px auto; padding-left: 370px; padding-right: 30px; overflow: auto;">
            <div>
                <table width="50%">
                    <tr>
                        <td colspan="2" style="background-color: Green; height: 30px; color: White;" align="center">Salesman
                        </td>
                    </tr>
                    <tr>
                        <td>Salesman Id</td>
                        <td>
                            <asp:TextBox ID="txtSalesmanId" Width="150px" runat="server"></asp:TextBox>
                            <asp:Button ID="btnDelete" runat="server" Width="100px" Text="Delete" OnClick="BtnDelete_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>Salesman Name </td>
                        <td>
                            <asp:TextBox ID="txtSalesman_name" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>City</td>
                        <td>
                            <asp:TextBox ID="txtCity" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>Commission</td>
                        <td>
                            <asp:TextBox ID="txtCommission" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>       
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="btnInsert" runat="server" Width="100px" Text="Save" OnClick="BtnInsert_Click" />
                            <asp:Button ID="btnUpdate" runat="server" Width="100px" Text="Update" OnClick="BtnUpdate_Click" />
                        </td>
                    </tr>
                </table>
             </div>
        </div>
    </form>
     <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        <div>
        </div>
</body>
</html>
