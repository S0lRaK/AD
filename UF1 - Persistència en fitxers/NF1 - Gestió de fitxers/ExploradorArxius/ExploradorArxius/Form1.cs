using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploradorArxius
{
    public partial class FormExplorador : Form
    {
        public FormExplorador()
        {
            InitializeComponent();
        }

        private void FormExplorador_Load(object sender, EventArgs e)
        {
            DirectoryInfo directori = new DirectoryInfo("C:\\Users\\CarlosJ");

            try
            {

            }
            catch
            {

            }
        }
    }
}
