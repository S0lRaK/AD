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
    public partial class FormInici : Form
    {
        FormTipusPaper formTipusPaper = new FormTipusPaper();
        FormTemes formTemes = new FormTemes();
        
        public FormInici()
        {
            InitializeComponent();
        }

        private void tipusDePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTipusPaper.Show();
        }

        private void temesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTemes.Show();
        }
    }
}
