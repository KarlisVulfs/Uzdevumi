<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="asp.netcrud.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfContactID" runat="server" />
            <table>
                <!--Name label -->
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!--LastName label -->
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!--Debt-->
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Debt"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtDebt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <!--Payment label -->
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Payment"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtPayment" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                   <!--Assign buttons -->
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="Save"/>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear"  />

                    </td>
                </tr>
                <tr>
                    <!--Success Message -->
                    <td colspan="2">
                        <asp:Label ID="lblSuccessMessage" runat="server" Text="" ForeColor="Green"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <!--Error message -->
                    <td colspan="2">
                        <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>

                    </td>
                </tr>

            </table>

            <br />
            <!--Generate table with user values -->
            <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" />
                    <asp:BoundField DataField="Debt" HeaderText="Debt" />
                    <asp:BoundField DataField="Payment" HeaderText="Payment" />
                   
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("ContactID") %>'>View</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>



            </asp:GridView>



        </div>
    </form>

</body>
</html>
