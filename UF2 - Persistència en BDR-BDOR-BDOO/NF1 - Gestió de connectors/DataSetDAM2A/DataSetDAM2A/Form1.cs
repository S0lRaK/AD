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

namespace DataSetDAM2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAulacep.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.dataSetAulacep.cursos);
            // TODO: esta línea de código carga datos en la tabla 'dataSetAulacep.cicles' Puede moverla o quitarla según sea necesario.
            this.ciclesTableAdapter.Fill(this.dataSetAulacep.cicles);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ciclesTableAdapter.Update(dataSetAulacep);
                dataSetAulacep.cicles.AcceptChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + " - " + ex.Message);
                dataSetAulacep.cicles.RejectChanges();
            }
        }
    }
}
