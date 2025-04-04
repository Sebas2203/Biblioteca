using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
    public partial class RegistrarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AgregarLibro_Click(object sender, EventArgs e)
        {
            //se llama a la capa de negocios para obtener lso articulso
            //instancia de la capa de negocios

            Negocios.lnBiblioteca negocios = new Negocios.lnBiblioteca();

            //ejecutar el metodo
            var resultado = negocios.RegistrarLibro(Titulo.Text, Editorial.Text, int.Parse(Paginas.Text), nombre.Text, 
                                                    apellidos.Text, nacionalidad.Text, int.Parse(cantidad.Text));
            Mensaje.Text = resultado;
        }
    }
}

