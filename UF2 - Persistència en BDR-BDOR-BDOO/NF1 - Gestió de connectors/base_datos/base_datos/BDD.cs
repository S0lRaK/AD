using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace base_datos
{
    static class BDD
    {
        static public SqlConnection conexion =
            new SqlConnection("Data Source=(local)\\sqlexpress2014;Initial Catalog=aulacep;Persist Security Info=True;User ID=sa;Password=sqlserver");

        static public void abrirConexion()
        {
            conexion.Open();
        }

        static public void cerrarConexion()
        {
            conexion.Close();
        }

        static public DataTable select(string nombreTabla)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos;
            DataTable tabla = null;

            try
            {
                sentencia.Connection = BDD.conexion;
                sentencia.CommandText = "select * from " + nombreTabla;

                conexion.Open();

                datos = sentencia.ExecuteReader();

                tabla = new DataTable();
                //tabla.Clear();
                tabla.Load(datos);

                //datos.Close();
                conexion.Close();
            }
            catch(SqlException ex)
            {
                switch(ex.Number)
                {
                    case -1:
                        MessageBox.Show("No es posible la conexión con el servidor.");
                        break;
                    case 4060:
                        MessageBox.Show("Base de Datos incorrecta.");
                        break;
                    case 18456:
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                        break;
                    default:
                        MessageBox.Show(ex.Number + " - " + ex.Message);
                        break;
                }
            }
            return tabla;
        }
    }
}
