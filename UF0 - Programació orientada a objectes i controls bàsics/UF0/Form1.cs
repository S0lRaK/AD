using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF0
{
    public partial class Form1 : Form
    {
        /* 
         *****  VARIABLES
         */
        String[] cursosMati = { "ASIX1A", "ASIX2A", "DAM1A", "DAM2A", "DAW1A", "DAW2A" };
        String[] cursosTarda = { "ASIX1T", "DAM1T", "DAW1T", "DAM2T" };

        String[] profesASIX1A = { "Fernández, Francisco", "Segura, Consuelo", "Serrano, Joan" };
        String[] profesASIX2A = { "Galcerà, Xavier", "Méndez, Urbano", "Ríos, Alex", "Segura, Consuelo", "Serrano, Joan", "Sotorra, Miquel" };
        String[] profesDAM1A = { "Fernández, Francisco", "Méndez, Urbano", "Segura, Consuelo", "Serrano, Joan" };
        String[] profesDAM2A = { "Domingo, Antonio", "Fernández, Francisco", "Ríos, Alex", "Segura, Consuelo", "Serrano, Joan" };
        String[] profesDAW1A = { "Fernández, Francisco", "Segura, Consuelo", "Serrano, Joan" };
        String[] profesDAW2A = { "Domingo, Antonio", "Fernández, Francisco", "Méndez, Urbano", "Serrano, Joan" };
        String[] profesDAM1T = { "García, José Luís", "Méndez, Urbano", "Ríos, Alex" };
        String[] profesASIX1T = { "García, José Luís", "Méndez, Urbano", "Ríos, Alex" };
        String[] profesDAW1T = { "García, José Luís", "Méndez, Urbano", "Ríos, Alex" };
        String[] profesDAM2T = { "Domingo, Antonio", "Fernández, Francisco", "Méndez, Urbano", "Ríos, Alex" };

        public Form1()
        {
            InitializeComponent();
        }

        /*
         *****  ESDEVENIMENTS
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            omplirCursos(radioButtonMatiMatriculat, comboBoxCursMatriculat);
            omplirCursos(radioButtonMatiInteressat, comboBoxCursInteressat);
        }

        private void radioButtonMatiMatriculat_CheckedChanged(object sender, EventArgs e)
        {
            omplirCursos(radioButtonMatiMatriculat, comboBoxCursMatriculat);
            textBoxTutorMatriculat.Clear();
            comboBoxProfeMatriculat.Items.Clear();
        }

        private void radioButtonMatiInteressat_CheckedChanged(object sender, EventArgs e)
        {
            omplirCursos(radioButtonMatiInteressat, comboBoxCursInteressat);
            textBoxTutorInteressat.Clear();
            comboBoxProfeInteressat.Items.Clear();
        }

        private void comboBoxCursMatriculat_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarTutorProfes(comboBoxCursMatriculat, textBoxTutorMatriculat, comboBoxProfeMatriculat);
        }

        private void comboBoxCursInteressat_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarTutorProfes(comboBoxCursInteressat, textBoxTutorInteressat, comboBoxProfeInteressat);
        }

        private void buttonAfegirResum_Click(object sender, EventArgs e)
        {

        }

        /*
         *****  MÈTODES PROPIS
         */ 
        private void omplirCursos(RadioButton rb, ComboBox cb)
        {
            // Neteja primerament qualsevol col·lecció prèvia...
            cb.Items.Clear();
            // ... per injectar una nova segons el torn
            if (rb.Checked) // Torn Matí
            {
                cb.Items.AddRange(cursosMati);
            }
            else // Torn Tarda
            {
                cb.Items.AddRange(cursosTarda);
            }
        }
        
        /*
         *  Segons el curs seleccionat, inserta informació del tutor i professors assignats.
         */  
        private void asignarTutorProfes(ComboBox cbCurs, TextBox tutor, ComboBox cbProfes)
        {
            // Es pasa l'objecte tipus Item (que conté un string) al tipus String per a que el SWITCH l'accepti
            switch(cbCurs.SelectedItem.ToString())
            {
                case "ASIX1A":
                    tutor.Text = "Segura, Consuelo";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesASIX1A);
                    break;
                case "ASIX2A":
                    tutor.Text = "Galcerà, Xavier";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesASIX2A);
                    break;
                case "DAM1A":
                    tutor.Text = "Segura, Consuelo";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAM1A);
                    break;
                case "DAM2A":
                    tutor.Text = "Ríos, Alex";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAM2A);
                    break;
                case "DAW1A":
                    tutor.Text = "Segura, Consuelo";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAW1A);
                    break;
                case "DAW2A":
                    tutor.Text = "Domingo, Antonio";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAW2A);
                    break;
                case "DAM1T":
                    tutor.Text = "García, José Luís";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAM1T);
                    break;
                case "ASIX1T":
                    tutor.Text = "García, José Luís";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesASIX1T);
                    break;
                case "DAW1T":
                    tutor.Text = "García, José Luís";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAW1T);
                    break;
                case "DAM2T":
                    tutor.Text = "Fernández, Francisco";
                    cbProfes.Items.Clear();
                    cbProfes.Items.AddRange(profesDAM2T);
                    break;
            }
        }
    }
}