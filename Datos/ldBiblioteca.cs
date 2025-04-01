using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//ADO.NET
using System.Configuration;
using System.Data;

namespace Datos
{
    public class ldBiblioteca
    {
        #region connection string

        private SqlConnection _connection;

        public ldBiblioteca()
        {
            initConnection();
        }
        public void initConnection()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }

        #endregion

        #region Metodos de acceso a la db

        //me devuelve un select
        public DataTable ConsultarLibro(int idlibro, string titulo)
        {
            try
            {
                //definir el comando para ejecutrar el SQL
                using (SqlCommand cmd = new SqlCommand("dbo.spConsultaLibro", _connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //agregar los parametros para realizar la llamada
                    cmd.Parameters.AddWithValue("@idlibro", idlibro <= 0 ? (object)DBNull.Value : idlibro);
                    cmd.Parameters.AddWithValue("@titulo", string.IsNullOrEmpty(titulo) ? (object)DBNull.Value : titulo);

                    //definir un adapter -> convierte los tipos de datos del select a un datatable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        //crear un datatable para almacenar los datos
                        DataTable resultado = new DataTable("dtLibros");

                        //abrir la conexion a la db
                        _connection.Open();

                        //llenar el datatable con los datos del select
                        adapter.Fill(resultado);
                        return resultado;
                    }


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cerrar la conexion a la db
                if (_connection.State == ConnectionState.Open) { _connection.Close(); };
            }
        }

        #endregion
    }
}
