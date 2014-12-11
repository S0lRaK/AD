using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace dam2a
{
    static class BD
    {
        static SqlConnection connexio = new SqlConnection("Data Source=(local);Initial Catalog=aulacep;Persist Security Info=True;User ID=sa;Password=mario");

        static public DataTable ObtenerTabla(string nomTabla)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos;

            DataTable tabla = new DataTable();

            sentencia.Connection = connexio;
            sentencia.CommandText = "select * from " + nomTabla;

            connexio.Open();

            datos = sentencia.ExecuteReader();

            tabla.Load(datos);
            datos.Close();

            connexio.Close();

            return tabla;
        }

        static public DataTable ObtenerCursosPorCiclo(int idCicle)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos;

            DataTable tabla = new DataTable();
            string mensaje = "";

            sentencia.Connection = connexio;
            sentencia.CommandText =
                "select * from cursos where id_cicle = @id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@id", idCicle);
            try
            { 
                connexio.Open();
                datos = sentencia.ExecuteReader();

                tabla.Load(datos);

                connexio.Close();
            }
            catch(SqlException ex)
            {
                mensaje = BdErrores.MensajeError(ex);
            }

            return tabla;
        }

        static public string InsertarCiclo(int id, string codi, string desc)
        {
            SqlCommand sentencia = new SqlCommand();
            string mensaje = "";

            sentencia.CommandText =
                "insert into cicles values (@identificador, @codigo, @desc)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@identificador", id);
            sentencia.Parameters.AddWithValue("@codigo", codi);
            sentencia.Parameters.AddWithValue("@desc", desc);

            sentencia.Connection = connexio;
            try
            {
                connexio.Open();
                sentencia.ExecuteNonQuery();
                connexio.Close();
            }
            catch (SqlException ex)
            {
                mensaje = BdErrores.MensajeError(ex);
            }

            return mensaje;
        }

        static public string ObtenerCicloPorId (int id)
        {
            SqlCommand sentencia = new SqlCommand();
            string codi = "";

            sentencia.CommandText =
                "select codi from cicles where id=@id";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@id", id);

            sentencia.Connection = connexio;

            connexio.Open();
            codi = sentencia.ExecuteScalar().ToString();
            connexio.Close();

            return (codi);
        }
    }
}
