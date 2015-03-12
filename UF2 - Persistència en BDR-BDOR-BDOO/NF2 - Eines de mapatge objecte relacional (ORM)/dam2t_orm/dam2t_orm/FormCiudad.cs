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
    public partial class FormCiudad : Form
    {
        public FormCiudad()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            string mensaje = Bd.CiudadInsert(int.Parse(textBoxIdentificador.Text), textBoxNombre.Text);
            if (mensaje!="")
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Alta correcta");
            }
        }
    }
}
