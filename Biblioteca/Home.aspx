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
                <div class="logo">
                    <img src="content\media\LogoUH.png" alt="logouh" />
                </div>
                <nav>
                    <ul>
                        <li><a href="Home.aspx" runat="server">Home</a></li>
                        <!--<li><a href="Carrito.aspx" runat="server">Carrito</a></li>-->
                    </ul>
                </nav>
                <div>
                    <asp:ImageButton ID="btnCarrito" runat="server" ImageUrl="~/Content/Media/carrito.png" CssClass="btnCarrito" />
                </div>
            </header>

            <div class="contenedor">
                <h1>Administracion de Libros</h1>
                <div id="divArticulos" runat="server">
                    <asp:GridView ID="gridLibros" runat="server" CssClass="gridview tablaArticulos" AutoGenerateColumns="true"></asp:GridView>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
