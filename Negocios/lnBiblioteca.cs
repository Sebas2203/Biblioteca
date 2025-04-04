using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class lnBiblioteca
    {
        //metodo que consulta articulos en la capa de datos
        public DataTable BuscarLibros(string nombreAutor, string tituloParcial)
        {
            try
            {


                //instanciar la capa de datos
                Datos.ldBiblioteca datos = new Datos.ldBiblioteca();

                //se ejecuta la llamada
                var resultado = datos.BuscarLibros(nombreAutor, tituloParcial);

                //si se require, se realiza una validacion de la info obtenida de la capa de datos

                //retorna el resultado
                return resultado;


            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
