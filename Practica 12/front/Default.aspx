<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:formview runat="server" DataSourceID="ObjectDataSource1" AllowPaging="True">
            <EditItemTemplate>

                bio_pe:
                <asp:TextBox ID="bio_peTextBox" runat="server" Text='<%# Bind("bio_pe") %>' />
                <br />
                dni_pe:
                <asp:TextBox ID="dni_peTextBox" runat="server" Text='<%# Bind("dni_pe") %>' />
                <br />
                email_pe:
                <asp:TextBox ID="email_peTextBox" runat="server" Text='<%# Bind("email_pe") %>' type="email" />
                <br />
                fecha_pe:
                <asp:TextBox ID="fecha_peTextBox" runat="server" Text='<%# Bind("fecha_pe") %>' type="date" />
                <br />
                foto_pe:
                <asp:TextBox ID="foto_peTextBox" runat="server" Text='<%# Bind("foto_pe") %>' type="url" />
                <br />
                nombres_pe:
                <asp:TextBox ID="nombres_peTextBox" runat="server" Text='<%# Bind("nombres_pe") %>' />
                <br />
                web_pe:
                <asp:TextBox ID="web_peTextBox" runat="server" Text='<%# Bind("web_pe") %>' type="url" />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                bio_pe:
                <asp:TextBox ID="bio_peTextBox" runat="server" Text='<%# Bind("bio_pe") %>' />
                <br />
                dni_pe:
                <asp:TextBox ID="dni_peTextBox" runat="server" Text='<%# Bind("dni_pe") %>' />
                <br />
                email_pe:
                <asp:TextBox ID="email_peTextBox" runat="server" Text='<%# Bind("email_pe") %>' />
                <br />
                fecha_pe:
                <asp:TextBox ID="fecha_peTextBox" runat="server" Text='<%# Bind("fecha_pe") %>' />
                <br />
                foto_pe:
                <asp:TextBox ID="foto_peTextBox" runat="server" Text='<%# Bind("foto_pe") %>' />
                <br />
                id_pe:
                <asp:TextBox ID="id_peTextBox" runat="server" Text='<%# Bind("id_pe") %>' />
                <br />
                nombres_pe:
                <asp:TextBox ID="nombres_peTextBox" runat="server" Text='<%# Bind("nombres_pe") %>' />
                <br />
                web_pe:
                <asp:TextBox ID="web_peTextBox" runat="server" Text='<%# Bind("web_pe") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                bio_pe:
                <asp:Label ID="bio_peLabel" runat="server" Text='<%# Bind("bio_pe") %>' />
                <br />
                dni_pe:
                <asp:Label ID="dni_peLabel" runat="server" Text='<%# Bind("dni_pe") %>' />
                <br />
                email_pe:
                <asp:Label ID="email_peLabel" runat="server" Text='<%# Bind("email_pe") %>' />
                <br />
                fecha_pe:
                <asp:Label ID="fecha_peLabel" runat="server" Text='<%# Bind("fecha_pe") %>' />
                <br />
                foto_pe:
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("foto_pe") %>' />
                <br />
                id_pe:
                <asp:Label ID="id_peLabel" runat="server" Text='<%# Bind("id_pe") %>' />
                <br />
                nombres_pe:
                <asp:Label ID="nombres_peLabel" runat="server" Text='<%# Bind("nombres_pe") %>' />
                <br />
                web_pe:
                <asp:Label ID="web_peLabel" runat="server" Text='<%# Bind("web_pe") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Nuevo" />
            </ItemTemplate>
        </asp:formview>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ServiceReference1.personas" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="Seleccionar" TypeName="ServiceReference1.ServiceClient" UpdateMethod="Actualizar"></asp:ObjectDataSource>
    </form>
</body>
</html>
