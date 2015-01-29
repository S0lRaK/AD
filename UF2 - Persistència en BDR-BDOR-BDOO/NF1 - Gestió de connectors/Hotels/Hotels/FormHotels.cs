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

        }
    }
}
