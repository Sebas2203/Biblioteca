<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarLibro.aspx.cs" Inherits="Biblioteca.RegistrarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <a href="Home.aspx">Home</a>


        <div>
            <p>Titulo</p>
            <asp:TextBox ID="Titulo" runat="server"></asp:TextBox> 
            <p>Editorial</p>
            <asp:TextBox ID="Editorial" runat="server"></asp:TextBox>
            <p>Paginas</p>
            <asp:TextBox ID="Paginas" runat="server"></asp:TextBox>
            <p>nombre</p>
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
            <p>apellidos</p>
            <asp:TextBox ID="apellidos" runat="server"></asp:TextBox>
            <p>nacionalidad</p>
            <asp:TextBox ID="nacionalidad" runat="server"></asp:TextBox>
            <p>cantidad</p>
            <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>

            <asp:Label ID="Mensaje" runat="server"></asp:Label>
            <!--boton de agregar libro-->
            <asp:Button ID="AgregarLibro" runat="server" Text="Agregar" onclick="AgregarLibro_Click"/>



        </div>
    </form>
</body>
</html>
