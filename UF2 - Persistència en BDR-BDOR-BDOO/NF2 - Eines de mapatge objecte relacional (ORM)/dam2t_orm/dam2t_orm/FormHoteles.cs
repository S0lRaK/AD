using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dam2t_orm
{
    public partial class FormHoteles : Form
    {
        public FormHoteles()
        {
            InitializeComponent();
        }

        private void FormHoteles_Load(object sender, EventArgs e)
        {
            //bindingSourceHoteles.DataSource = Bd.HotelesSelect();
            bindingSourceCiudades.DataSource = Bd.CiudadesSelect();

            ciudades c = Bd.CiudadesSelectPorId((int)comboBoxCiudades.SelectedValue);

            bindingSourceHoteles.DataSource = c.hoteles;
        }

        private void comboBoxCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudades c = Bd.CiudadesSelectPorId((int)comboBoxCiudades.SelectedValue);

            bindingSourceHoteles.DataSource = c.hoteles;
        }

    }
}
