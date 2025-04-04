<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Biblioteca.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Biblioteca</title>
</head>
<body>
    <h1>Biblioteca</h1>
    <form id="form1" runat="server">
        <div>
            <header>
                <a href="RegistrarLibro.aspx">Registrar Libro</a>
            </header>

            <div class="contenedor">
                <h1>Administracion de Libros</h1>
                <div id="divArticulos" runat="server">
                    <asp:GridView ID="gridLibros" runat="server" CssClass="gridview tablaArticulos" AutoGenerateColumns="true"></asp:GridView>
                </div>
            </div>

            <div class="Buscar">
                <h1>Buscar Libro</h1>
                <p>Autor</p>
                <asp:TextBox ID="BuscarAutor" runat="server" CssClass="BuscarLibroTB" />
                <p>Titulo Libro</p>
                <asp:TextBox ID="BuscarTitulo" runat="server" CssClass="BuscarLibroTB" />
                <asp:Button ID="BuscarLibroBTN" runat="server" Text="Buscar" OnClick="BuscarLibroBTN_Click" />
            </div>

        </div>
    </form>
</body>
</html>
