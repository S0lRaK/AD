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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            string mensaje;
            //sentencia.CommandText =
            //    "insert into cicles values (" +
            //        textBoxId.Text +",'" + textBoxCodi.Text + "','"+
            //        textBoxDescripcio.Text +"')";

            mensaje = BD.InsertarCiclo(int.Parse(textBoxId.Text), textBoxCodi.Text, textBoxDescripcio.Text);

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            textBoxCodi.Text = BD.ObtenerCicloPorId(int.Parse(textBoxId.Text));
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            cursos formulario = new cursos();

            formulario.ShowDialog();
        }
    }
}
