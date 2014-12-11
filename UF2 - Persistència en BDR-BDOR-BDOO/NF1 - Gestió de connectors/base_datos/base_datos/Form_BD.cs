using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace base_datos
{
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            InitializeComponent();
        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand sentencia = new SqlCommand();

            conexion.ConnectionString = "Data Source=(local)\\sqlexpress2014;Initial Catalog=aulacep;Persist Security Info=True;User ID=sa;Password=sqlserver";

            //sentencia.CommandText = "insert into cicles values (" +
            //                        textBoxId.Text + ", '" + 
            //                        textBoxCodi.Text + "', '" +
            //                        textBoxDescripcion.Text + "')";

            //sentencia.CommandText = "insert into cicles values (@id, @codigo, @descripcion)";
            sentencia.CommandText = "select * from cicles where id = @id";

            /*
             *  Se eliminan parámetros anteriores (por si los había)
             */
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@id", textBoxId.Text);
            //sentencia.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);
            //sentencia.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);

            /*
             *  Define la conexión que usara la sentencia al ejecutarse
             */
            sentencia.Connection = conexion;

            conexion.Open();

            //sentencia.ExecuteNonQuery();

            /*
             *  Retorna un sol registre
             */
            // textBoxCodigo.Text = sentencia.ExecuteScalar().ToString();

            SqlDataReader datos;
            datos = sentencia.ExecuteReader();

            if(datos.Read())
            {
                textBoxCodigo.Text = datos["codi"].ToString();
                textBoxDescripcion.Text = datos["descripcio"].ToString();
            }
            //datos.Close();

            conexion.Close();
        }
    }
}