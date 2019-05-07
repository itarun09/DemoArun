<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemDetails.aspx.cs" Inherits="DemoApp.ItemDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table align="center">
                <tr>
                    <td>Item Name::</td>
                    <td>
                        <asp:TextBox ID="txtItem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Description::</td>
                    <td>
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btncreate" runat="server" Text="Create" OnClick="btncreate_Click" />
                        <br />
                        <asp:Label ID="lblmessage" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>
            <br />
            <table align="center">
                <asp:GridView ID="gridItem" DataKeyNames="ItemId" runat="server" AutoGenerateColumns="false" OnRowCancelingEdit="gridItem_RowCancelingEdit" OnRowEditing="gridItem_RowEditing" OnRowUpdating="gridItem_RowUpdating">

                    <Columns>
                        <asp:TemplateField HeaderText="Item Name" ItemStyle-Width="30">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCustomerId" runat="server" Text='<%# Eval("ItemName") %>' />
                            </ItemTemplate>
                            <EditItemTemplate>
                                 <asp:TextBox ID="txtCustomerIdedit" runat="server" Text='<%# Eval("ItemName") %>' />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ItemDescription" ItemStyle-Width="150">
                            <ItemTemplate>
                                <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("ItemDesc") %>' />
                            </ItemTemplate>
                            <EditItemTemplate>   <asp:TextBox ID="txtNameedit" runat="server" Text='<%# Eval("ItemDesc") %>' /></EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status" ItemStyle-Width="150">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCountry" runat="server" Text='<%# Eval("Status") %>' />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <%--<asp:DropDownList ID="ddldro" runat="server">
                                    <asp:ListItem Text="Active" Value="0"></asp:ListItem>
                                      <asp:ListItem Text="InActive" Value="1"></asp:ListItem>
                                </asp:DropDownList--%>>
                                 <asp:TextBox ID="txtCountryedit" runat="server" Text='<%# Eval("Status") %>' />
                            </EditItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Date" ItemStyle-Width="150">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCreatedDate" runat="server" Text='<%# Eval("CreatedDate") %>' />
                            </ItemTemplate>
                             <EditItemTemplate> <asp:TextBox ID="txtCreatedDateedit" runat="server" Text='<%# Eval("CreatedDate") %>' /></EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">

                        <ItemTemplate>

                           <asp:LinkButton ID="imgbtnEdit" runat="server" CommandName="Edit" Height="32px" Width="32px" Text="Edit"/>

                           <asp:LinkButton ID="imgbtnDelete" runat="server" CommandName="Delete" Text="Delete" />

                        </ItemTemplate>

                        <EditItemTemplate>

                           <asp:LinkButton ID="imgbtnUpdate" runat="server" CommandName="Update" Text="Update" />

                           <asp:LinkButton ID="imgbtnCancel" runat="server" CommandName="Cancel" Text="Cancel"/>

                        </EditItemTemplate>

                       

                    </asp:TemplateField>
                    </Columns>


                </asp:GridView>
            </table>

        </div>
    </form>
</body>
</html>
