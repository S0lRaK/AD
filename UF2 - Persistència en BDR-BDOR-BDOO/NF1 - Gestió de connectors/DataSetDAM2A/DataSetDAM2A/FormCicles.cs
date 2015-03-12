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
    public partial class FormCicles : Form
    {
        public FormCicles()
        {
            InitializeComponent();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            DataSetAulacep.ciclesRow fila;
            int id;

            try
            {
                fila = dataSetAulacep.cicles.NewciclesRow();

                if (int.TryParse(textBoxId.Text, out id))
                {
                    fila.id = id;
                    fila.codi = textBoxCodi.Text;
                    fila.descripcio = textBoxDescripció.Text;

                    dataSetAulacep.cicles.AddciclesRow(fila);

                    ciclesTableAdapter.Update(dataSetAulacep);
                    dataSetAulacep.cicles.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("El id ha de ser numérico");
                }
            }
            catch(ConstraintException)
            {
                MessageBox.Show("El id esta repetido");
                textBoxId.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + " - " + ex.Message);
            }

        }

        private void FormCicles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAulacep.cicles' Puede moverla o quitarla según sea necesario.
            this.ciclesTableAdapter.Fill(this.dataSetAulacep.cicles);

        }

        private void buttonModificacio_Click(object sender, EventArgs e)
        {
            DataSetAulacep.ciclesRow fila;

            int id;

            id = int.Parse(textBoxId.Text);

            fila = dataSetAulacep.cicles.FindByid(id);

            if (fila != null)
            {
                fila.codi = textBoxCodi.Text;
                fila.descripcio = textBoxDescripció.Text;

                ciclesTableAdapter.Update(dataSetAulacep);
                dataSetAulacep.cicles.AcceptChanges();
            }
            else
            {
                MessageBox.Show("El ciclo no existe");
                textBoxId.Focus();
            }
        }

        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            DataSetAulacep.ciclesRow fila;

            int id;
            try
            {
                id = int.Parse(textBoxId.Text);


                fila = dataSetAulacep.cicles.FindByid(id);
                if (fila != null)
                {
                    fila.Delete();

                    ciclesTableAdapter.Update(dataSetAulacep);
                    dataSetAulacep.cicles.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("El ciclo no existe");
                    textBoxId.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + " - " + ex.Message);
            }
        }
    }
}
