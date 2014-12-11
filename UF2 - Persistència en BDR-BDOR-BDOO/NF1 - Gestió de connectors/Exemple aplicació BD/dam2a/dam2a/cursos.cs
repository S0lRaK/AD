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

namespace dam2a
{
    public partial class cursos : Form
    {

        public cursos()
        {
            InitializeComponent();
        }

        private void cursos_Load(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();
                
            //tabla = BD.ObtenerTabla("cicles");

            comboBoxCicles.DisplayMember = "codi";
            comboBoxCicles.ValueMember = "id";
            //comboBoxCicles.DataSource = tabla;
            comboBoxCicles.DataSource = BD.ObtenerTabla("cicles");

            //tabla = new DataTable();

            //tabla = BD.ObtenerTabla("cursos");

            //dataGridViewCursos.DataSource = tabla;
            dataGridViewCursos.DataSource = BD.ObtenerTabla("cursos");
        }

        private void comboBoxCicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCicle = (int)comboBoxCicles.SelectedValue;
            DataTable tabla = new DataTable();
            tabla = BD.ObtenerCursosPorCiclo(idCicle);
            dataGridViewCursos.DataSource = tabla;

            tabla = new DataTable();
            tabla = BD.ObtenerCursosPorCiclo((int)comboBoxCicles.SelectedValue);
            dataGridViewCursos.DataSource = tabla;
        }
    }
}
