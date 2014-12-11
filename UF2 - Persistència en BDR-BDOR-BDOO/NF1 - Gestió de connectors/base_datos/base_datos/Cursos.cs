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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            comboBoxCicles.DisplayMember = "codi";
            comboBoxCicles.ValueMember = "id";
            comboBoxCicles.DataSource = BDD.select("cicles");

            dataGridViewCursos.DataSource = BDD.select("cursos");
        }

        private void comboBoxCicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader datos;
            DataTable tabla;

            sentencia.Connection = BDD.conexion;
            sentencia.CommandText = "select * from cursos where id_cicle = @id_cicle";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@id_cicle", comboBoxCicles.SelectedValue);

            BDD.abrirConexion();

            datos = sentencia.ExecuteReader();

            tabla = new DataTable();
            tabla.Load(datos);

            dataGridViewCursos.DataSource = tabla;

            datos.Close();

            BDD.cerrarConexion();
        }
    }
}
