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



        public string RegistrarLibro(string titulo, string editorial, int paginas,
                                     string nombreAutor, string apellidosAutor, string nacionalidad, int cantidadEjemplares)
        {
            //using (SqlConnection con = new SqlConnection(_connection))
            //{
            try
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand("dbo.RegistrarLibro", _connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@editorial", editorial);
                cmd.Parameters.AddWithValue("@paginas", paginas);
                cmd.Parameters.AddWithValue("@nombre_autor", nombreAutor);
                cmd.Parameters.AddWithValue("@apellidos_autor", apellidosAutor);
                cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                cmd.Parameters.AddWithValue("@cantidad_ejemplares", cantidadEjemplares);

                // Parámetro de salida
                SqlParameter outputParam = new SqlParameter("@mensaje", SqlDbType.NVarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();

                // Retornar el mensaje del SP
                return outputParam.Value.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        //}

        public DataTable BuscarLibros(string nombreAutor, string tituloParcial)
        {
            DataTable dt = new DataTable();

            try
            {
                //using (SqlConnection con = new SqlConnection(connectionString))
                //{
                _connection.Open(); // Abrimos la conexión

                using (SqlCommand cmd = new SqlCommand("dbo.BuscarLibros", _connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros opcionales (si están vacíos, se envía NULL)
                        cmd.Parameters.AddWithValue("@nombre_autor", string.IsNullOrEmpty(nombreAutor) ? (object)DBNull.Value : nombreAutor);
                        cmd.Parameters.AddWithValue("@titulo_parcial", string.IsNullOrEmpty(tituloParcial) ? (object)DBNull.Value : tituloParcial);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
               //}
            }
            catch (SqlException ex)
            {
                // Manejo de errores de SQL (problemas con la base de datos)
                Console.WriteLine("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                Console.WriteLine("Error general: " + ex.Message);
            }

            return dt;
        }



    }
}
