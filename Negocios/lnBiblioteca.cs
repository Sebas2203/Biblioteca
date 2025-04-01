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
        public DataTable ConsultarLibro(int idLibro, string titulo)
        {
            try
            {
                //validar los tipos de datos
                if (idLibro >= 0)
                {
                    //instanciar la capa de datos
                    Datos.ldBiblioteca datos = new Datos.ldBiblioteca();

                    //se ejecuta la llamada
                    var resultado = datos.ConsultarLibro(idLibro, titulo);

                    //si se require, se realiza una validacion de la info obtenida de la capa de datos

                    //retorna el resultado
                    return resultado;
                }
                else
                {
                    throw new Exception("El id del Libro no puede ser menor o igual a 0");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
