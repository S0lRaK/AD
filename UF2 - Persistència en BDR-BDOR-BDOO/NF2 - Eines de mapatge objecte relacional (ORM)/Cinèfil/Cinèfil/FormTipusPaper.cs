using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinèfil
{
    public partial class FormTipusPaper : Form
    {
        FormAltaTipusPaper formAltaTipusPaper = new FormAltaTipusPaper();
        
        public FormTipusPaper()
        {
            InitializeComponent();
        }

        private void toolStripButton_Alta_Click(object sender, EventArgs e)
        {
            formAltaTipusPaper.ShowDialog();
        }

        private void toolStripButton_Cerca_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_Gravar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_Sortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
