using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels
{
    public partial class FormHotels : Form
    {
        FormHotel formHotel = new FormHotel();
        bool origenFormHotel = false;

        public FormHotels()
        {
            InitializeComponent();
        }

        private void FormHotels_Load(object sender, EventArgs e)
        {
            // Selecciona la columna de la taula de la BD que es mostrarà
            comboBoxCiutat.DisplayMember = "nombre";
            // Selecciona la columna de la taula de la BD que es guardarà
            comboBoxCiutat.ValueMember = "id_ciudad";

            // Relaciona el control amb les dades obtingudes
            comboBoxCiutat.DataSource = SentenciaSQL.obtenirTaula("ciudades");

            // Omple el GridView amb els hotels corresponents a la ciutat seleccionada
            dataGridViewHotels.DataSource = SentenciaSQL.obtenirHotelsDeCiutat((int)comboBoxCiutat.SelectedValue);
        }

        private void FormHotels_Activated(object sender, EventArgs e)
        {
            if (origenFormHotel)
            {
                comboBoxCiutat.DataSource = SentenciaSQL.obtenirTaula("ciudades");
                dataGridViewHotels.DataSource = SentenciaSQL.obtenirHotelsDeCiutat((int)comboBoxCiutat.SelectedValue);
                origenFormHotel = false;   
            }
        }

        private void toolStripButtonNouHotel_Click(object sender, EventArgs e)
        {
            origenFormHotel = true;
            formHotel.Text = "Alta Hotel";
            formHotel.ShowDialog();
        }

        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCiutat_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewHotels.DataSource = SentenciaSQL.obtenirHotelsDeCiutat((int)comboBoxCiutat.SelectedValue);
        }

        private void dataGridViewHotels_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Estàs segur/a d'esborrar l'hotel seleccionat?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(resposta == DialogResult.Yes)
            {
                
            }
            
        }

        private void dataGridViewHotels_DoubleClick(object sender, EventArgs e)
        {
            formHotel.Text = "Modificació Hotel";
            UInt16 idCiutat;
            formHotel.ShowDialog();
        }
    }
}
