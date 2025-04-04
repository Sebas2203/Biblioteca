using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se llama a la capa de negocios para obtener lso articulso
            //instancia de la capa de negocios

            Negocios.lnBiblioteca negocios = new Negocios.lnBiblioteca();

            //ejecutar el metodo
            var resultado = negocios.BuscarLibros("", string.Empty);

            //mostrar la tabla en el gridview
            gridLibros.DataSource = resultado;
            gridLibros.DataBind();
        }
    }
}