namespace UF0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDades = new System.Windows.Forms.GroupBox();
            this.buttonAfegirResum = new System.Windows.Forms.Button();
            this.groupBoxCursInteressat = new System.Windows.Forms.GroupBox();
            this.comboBoxProfeInteressat = new System.Windows.Forms.ComboBox();
            this.comboBoxCursInteressat = new System.Windows.Forms.ComboBox();
            this.textBoxTutorInteressat = new System.Windows.Forms.TextBox();
            this.labelProfeInteressat = new System.Windows.Forms.Label();
            this.labelTutorInteressat = new System.Windows.Forms.Label();
            this.labelCursInteressat = new System.Windows.Forms.Label();
            this.groupBoxTornInteressat = new System.Windows.Forms.GroupBox();
            this.radioButtonTardaInteressat = new System.Windows.Forms.RadioButton();
            this.radioButtonMatiInteressat = new System.Windows.Forms.RadioButton();
            this.groupBoxCursMatriculat = new System.Windows.Forms.GroupBox();
            this.comboBoxProfeMatriculat = new System.Windows.Forms.ComboBox();
            this.comboBoxCursMatriculat = new System.Windows.Forms.ComboBox();
            this.textBoxTutorMatriculat = new System.Windows.Forms.TextBox();
            this.labelProfeMatriculat = new System.Windows.Forms.Label();
            this.labelTutorMatriculat = new System.Windows.Forms.Label();
            this.labelCursMatriculat = new System.Windows.Forms.Label();
            this.groupBoxTornMatriculat = new System.Windows.Forms.GroupBox();
            this.radioButtonTardaMatriculat = new System.Windows.Forms.RadioButton();
            this.radioButtonMatiMatriculat = new System.Windows.Forms.RadioButton();
            this.groupBoxModulProfessional = new System.Windows.Forms.GroupBox();
            this.checkedListBoxUFs = new System.Windows.Forms.CheckedListBox();
            this.comboBoxModul = new System.Windows.Forms.ComboBox();
            this.labelModul = new System.Windows.Forms.Label();
            this.groupBoxDadesPersonals = new System.Windows.Forms.GroupBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCognoms = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCognoms = new System.Windows.Forms.Label();
            this.dateTimePickerPeticio = new System.Windows.Forms.DateTimePicker();
            this.labelDataPeticio = new System.Windows.Forms.Label();
            this.groupBoxResum = new System.Windows.Forms.GroupBox();
            this.textBoxResum = new System.Windows.Forms.TextBox();
            this.buttonEliminarTot = new System.Windows.Forms.Button();
            this.buttonEliminarSelec = new System.Windows.Forms.Button();
            this.groupBoxDades.SuspendLayout();
            this.groupBoxCursInteressat.SuspendLayout();
            this.groupBoxTornInteressat.SuspendLayout();
            this.groupBoxCursMatriculat.SuspendLayout();
            this.groupBoxTornMatriculat.SuspendLayout();
            this.groupBoxModulProfessional.SuspendLayout();
            this.groupBoxDadesPersonals.SuspendLayout();
            this.groupBoxResum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDades
            // 
            this.groupBoxDades.Controls.Add(this.buttonAfegirResum);
            this.groupBoxDades.Controls.Add(this.groupBoxCursInteressat);
            this.groupBoxDades.Controls.Add(this.groupBoxCursMatriculat);
            this.groupBoxDades.Controls.Add(this.groupBoxModulProfessional);
            this.groupBoxDades.Controls.Add(this.groupBoxDadesPersonals);
            this.groupBoxDades.Controls.Add(this.dateTimePickerPeticio);
            this.groupBoxDades.Controls.Add(this.labelDataPeticio);
            this.groupBoxDades.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDades.Name = "groupBoxDades";
            this.groupBoxDades.Size = new System.Drawing.Size(551, 323);
            this.groupBoxDades.TabIndex = 0;
            this.groupBoxDades.TabStop = false;
            this.groupBoxDades.Text = "Dades";
            // 
            // buttonAfegirResum
            // 
            this.buttonAfegirResum.AutoSize = true;
            this.buttonAfegirResum.Location = new System.Drawing.Point(11, 294);
            this.buttonAfegirResum.Name = "buttonAfegirResum";
            this.buttonAfegirResum.Size = new System.Drawing.Size(91, 23);
            this.buttonAfegirResum.TabIndex = 14;
            this.buttonAfegirResum.Text = "Afegir al Resum";
            this.buttonAfegirResum.UseMnemonic = false;
            this.buttonAfegirResum.UseVisualStyleBackColor = true;
            this.buttonAfegirResum.Click += new System.EventHandler(this.buttonAfegirResum_Click);
            // 
            // groupBoxCursInteressat
            // 
            this.groupBoxCursInteressat.Controls.Add(this.comboBoxProfeInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.comboBoxCursInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.textBoxTutorInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.labelProfeInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.labelTutorInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.labelCursInteressat);
            this.groupBoxCursInteressat.Controls.Add(this.groupBoxTornInteressat);
            this.groupBoxCursInteressat.Location = new System.Drawing.Point(284, 143);
            this.groupBoxCursInteressat.Name = "groupBoxCursInteressat";
            this.groupBoxCursInteressat.Size = new System.Drawing.Size(261, 145);
            this.groupBoxCursInteressat.TabIndex = 5;
            this.groupBoxCursInteressat.TabStop = false;
            this.groupBoxCursInteressat.Text = "Curs on vol anar";
            // 
            // comboBoxProfeInteressat
            // 
            this.comboBoxProfeInteressat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfeInteressat.FormattingEnabled = true;
            this.comboBoxProfeInteressat.Location = new System.Drawing.Point(84, 112);
            this.comboBoxProfeInteressat.Name = "comboBoxProfeInteressat";
            this.comboBoxProfeInteressat.Size = new System.Drawing.Size(168, 21);
            this.comboBoxProfeInteressat.TabIndex = 13;
            // 
            // comboBoxCursInteressat
            // 
            this.comboBoxCursInteressat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursInteressat.FormattingEnabled = true;
            this.comboBoxCursInteressat.Location = new System.Drawing.Point(84, 65);
            this.comboBoxCursInteressat.Name = "comboBoxCursInteressat";
            this.comboBoxCursInteressat.Size = new System.Drawing.Size(168, 21);
            this.comboBoxCursInteressat.TabIndex = 11;
            this.comboBoxCursInteressat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursInteressat_SelectedIndexChanged);
            // 
            // textBoxTutorInteressat
            // 
            this.textBoxTutorInteressat.Location = new System.Drawing.Point(84, 88);
            this.textBoxTutorInteressat.Name = "textBoxTutorInteressat";
            this.textBoxTutorInteressat.ReadOnly = true;
            this.textBoxTutorInteressat.Size = new System.Drawing.Size(168, 20);
            this.textBoxTutorInteressat.TabIndex = 12;
            // 
            // labelProfeInteressat
            // 
            this.labelProfeInteressat.AutoSize = true;
            this.labelProfeInteressat.Location = new System.Drawing.Point(7, 115);
            this.labelProfeInteressat.Name = "labelProfeInteressat";
            this.labelProfeInteressat.Size = new System.Drawing.Size(51, 13);
            this.labelProfeInteressat.TabIndex = 8;
            this.labelProfeInteressat.Text = "Professor";
            // 
            // labelTutorInteressat
            // 
            this.labelTutorInteressat.AutoSize = true;
            this.labelTutorInteressat.Location = new System.Drawing.Point(7, 91);
            this.labelTutorInteressat.Name = "labelTutorInteressat";
            this.labelTutorInteressat.Size = new System.Drawing.Size(32, 13);
            this.labelTutorInteressat.TabIndex = 7;
            this.labelTutorInteressat.Text = "Tutor";
            // 
            // labelCursInteressat
            // 
            this.labelCursInteressat.AutoSize = true;
            this.labelCursInteressat.Location = new System.Drawing.Point(7, 68);
            this.labelCursInteressat.Name = "labelCursInteressat";
            this.labelCursInteressat.Size = new System.Drawing.Size(28, 13);
            this.labelCursInteressat.TabIndex = 6;
            this.labelCursInteressat.Text = "Curs";
            // 
            // groupBoxTornInteressat
            // 
            this.groupBoxTornInteressat.Controls.Add(this.radioButtonTardaInteressat);
            this.groupBoxTornInteressat.Controls.Add(this.radioButtonMatiInteressat);
            this.groupBoxTornInteressat.Location = new System.Drawing.Point(9, 20);
            this.groupBoxTornInteressat.Name = "groupBoxTornInteressat";
            this.groupBoxTornInteressat.Size = new System.Drawing.Size(243, 37);
            this.groupBoxTornInteressat.TabIndex = 0;
            this.groupBoxTornInteressat.TabStop = false;
            this.groupBoxTornInteressat.Text = "Torn";
            // 
            // radioButtonTardaInteressat
            // 
            this.radioButtonTardaInteressat.AutoSize = true;
            this.radioButtonTardaInteressat.Location = new System.Drawing.Point(133, 13);
            this.radioButtonTardaInteressat.Name = "radioButtonTardaInteressat";
            this.radioButtonTardaInteressat.Size = new System.Drawing.Size(53, 17);
            this.radioButtonTardaInteressat.TabIndex = 10;
            this.radioButtonTardaInteressat.Text = "Tarda";
            this.radioButtonTardaInteressat.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatiInteressat
            // 
            this.radioButtonMatiInteressat.AutoSize = true;
            this.radioButtonMatiInteressat.Checked = true;
            this.radioButtonMatiInteressat.Location = new System.Drawing.Point(49, 13);
            this.radioButtonMatiInteressat.Name = "radioButtonMatiInteressat";
            this.radioButtonMatiInteressat.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMatiInteressat.TabIndex = 2;
            this.radioButtonMatiInteressat.TabStop = true;
            this.radioButtonMatiInteressat.Text = "Matí";
            this.radioButtonMatiInteressat.UseVisualStyleBackColor = true;
            this.radioButtonMatiInteressat.CheckedChanged += new System.EventHandler(this.radioButtonMatiInteressat_CheckedChanged);
            // 
            // groupBoxCursMatriculat
            // 
            this.groupBoxCursMatriculat.Controls.Add(this.comboBoxProfeMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.comboBoxCursMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.textBoxTutorMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.labelProfeMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.labelTutorMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.labelCursMatriculat);
            this.groupBoxCursMatriculat.Controls.Add(this.groupBoxTornMatriculat);
            this.groupBoxCursMatriculat.Location = new System.Drawing.Point(11, 143);
            this.groupBoxCursMatriculat.Name = "groupBoxCursMatriculat";
            this.groupBoxCursMatriculat.Size = new System.Drawing.Size(261, 145);
            this.groupBoxCursMatriculat.TabIndex = 4;
            this.groupBoxCursMatriculat.TabStop = false;
            this.groupBoxCursMatriculat.Text = "Curs on està matriculat";
            // 
            // comboBoxProfeMatriculat
            // 
            this.comboBoxProfeMatriculat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfeMatriculat.FormattingEnabled = true;
            this.comboBoxProfeMatriculat.Location = new System.Drawing.Point(87, 112);
            this.comboBoxProfeMatriculat.Name = "comboBoxProfeMatriculat";
            this.comboBoxProfeMatriculat.Size = new System.Drawing.Size(168, 21);
            this.comboBoxProfeMatriculat.TabIndex = 9;
            // 
            // comboBoxCursMatriculat
            // 
            this.comboBoxCursMatriculat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursMatriculat.FormattingEnabled = true;
            this.comboBoxCursMatriculat.Location = new System.Drawing.Point(87, 65);
            this.comboBoxCursMatriculat.Name = "comboBoxCursMatriculat";
            this.comboBoxCursMatriculat.Size = new System.Drawing.Size(168, 21);
            this.comboBoxCursMatriculat.TabIndex = 7;
            this.comboBoxCursMatriculat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursMatriculat_SelectedIndexChanged);
            // 
            // textBoxTutorMatriculat
            // 
            this.textBoxTutorMatriculat.Location = new System.Drawing.Point(87, 88);
            this.textBoxTutorMatriculat.Name = "textBoxTutorMatriculat";
            this.textBoxTutorMatriculat.ReadOnly = true;
            this.textBoxTutorMatriculat.Size = new System.Drawing.Size(168, 20);
            this.textBoxTutorMatriculat.TabIndex = 8;
            // 
            // labelProfeMatriculat
            // 
            this.labelProfeMatriculat.AutoSize = true;
            this.labelProfeMatriculat.Location = new System.Drawing.Point(11, 115);
            this.labelProfeMatriculat.Name = "labelProfeMatriculat";
            this.labelProfeMatriculat.Size = new System.Drawing.Size(51, 13);
            this.labelProfeMatriculat.TabIndex = 3;
            this.labelProfeMatriculat.Text = "Professor";
            // 
            // labelTutorMatriculat
            // 
            this.labelTutorMatriculat.AutoSize = true;
            this.labelTutorMatriculat.Location = new System.Drawing.Point(11, 91);
            this.labelTutorMatriculat.Name = "labelTutorMatriculat";
            this.labelTutorMatriculat.Size = new System.Drawing.Size(32, 13);
            this.labelTutorMatriculat.TabIndex = 2;
            this.labelTutorMatriculat.Text = "Tutor";
            // 
            // labelCursMatriculat
            // 
            this.labelCursMatriculat.AutoSize = true;
            this.labelCursMatriculat.Location = new System.Drawing.Point(11, 68);
            this.labelCursMatriculat.Name = "labelCursMatriculat";
            this.labelCursMatriculat.Size = new System.Drawing.Size(28, 13);
            this.labelCursMatriculat.TabIndex = 1;
            this.labelCursMatriculat.Text = "Curs";
            // 
            // groupBoxTornMatriculat
            // 
            this.groupBoxTornMatriculat.Controls.Add(this.radioButtonTardaMatriculat);
            this.groupBoxTornMatriculat.Controls.Add(this.radioButtonMatiMatriculat);
            this.groupBoxTornMatriculat.Location = new System.Drawing.Point(6, 19);
            this.groupBoxTornMatriculat.Name = "groupBoxTornMatriculat";
            this.groupBoxTornMatriculat.Size = new System.Drawing.Size(249, 37);
            this.groupBoxTornMatriculat.TabIndex = 0;
            this.groupBoxTornMatriculat.TabStop = false;
            this.groupBoxTornMatriculat.Text = "Torn";
            // 
            // radioButtonTardaMatriculat
            // 
            this.radioButtonTardaMatriculat.AutoSize = true;
            this.radioButtonTardaMatriculat.Location = new System.Drawing.Point(122, 14);
            this.radioButtonTardaMatriculat.Name = "radioButtonTardaMatriculat";
            this.radioButtonTardaMatriculat.Size = new System.Drawing.Size(53, 17);
            this.radioButtonTardaMatriculat.TabIndex = 6;
            this.radioButtonTardaMatriculat.Text = "Tarda";
            this.radioButtonTardaMatriculat.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatiMatriculat
            // 
            this.radioButtonMatiMatriculat.AutoSize = true;
            this.radioButtonMatiMatriculat.Checked = true;
            this.radioButtonMatiMatriculat.Location = new System.Drawing.Point(38, 14);
            this.radioButtonMatiMatriculat.Name = "radioButtonMatiMatriculat";
            this.radioButtonMatiMatriculat.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMatiMatriculat.TabIndex = 0;
            this.radioButtonMatiMatriculat.TabStop = true;
            this.radioButtonMatiMatriculat.Text = "Matí";
            this.radioButtonMatiMatriculat.UseVisualStyleBackColor = true;
            this.radioButtonMatiMatriculat.CheckedChanged += new System.EventHandler(this.radioButtonMatiMatriculat_CheckedChanged);
            // 
            // groupBoxModulProfessional
            // 
            this.groupBoxModulProfessional.Controls.Add(this.checkedListBoxUFs);
            this.groupBoxModulProfessional.Controls.Add(this.comboBoxModul);
            this.groupBoxModulProfessional.Controls.Add(this.labelModul);
            this.groupBoxModulProfessional.Location = new System.Drawing.Point(284, 57);
            this.groupBoxModulProfessional.Name = "groupBoxModulProfessional";
            this.groupBoxModulProfessional.Size = new System.Drawing.Size(261, 79);
            this.groupBoxModulProfessional.TabIndex = 3;
            this.groupBoxModulProfessional.TabStop = false;
            this.groupBoxModulProfessional.Text = "Mòdul Professional";
            // 
            // checkedListBoxUFs
            // 
            this.checkedListBoxUFs.ColumnWidth = 41;
            this.checkedListBoxUFs.FormattingEnabled = true;
            this.checkedListBoxUFs.Items.AddRange(new object[] {
            "UF1",
            "UF2",
            "UF3",
            "UF4",
            "UF5",
            "UF6"});
            this.checkedListBoxUFs.Location = new System.Drawing.Point(3, 47);
            this.checkedListBoxUFs.MultiColumn = true;
            this.checkedListBoxUFs.Name = "checkedListBoxUFs";
            this.checkedListBoxUFs.Size = new System.Drawing.Size(255, 19);
            this.checkedListBoxUFs.TabIndex = 5;
            // 
            // comboBoxModul
            // 
            this.comboBoxModul.FormattingEnabled = true;
            this.comboBoxModul.Items.AddRange(new object[] {
            "AD",
            "PSP",
            "PMDM",
            "P2",
            "ED",
            "DI",
            "DWEC",
            "DWES",
            "FOL",
            "EIE",
            "DIW",
            "BD",
            "BD2",
            "P1",
            "SI",
            "DAW",
            "PRO",
            "FCT"});
            this.comboBoxModul.Location = new System.Drawing.Point(74, 16);
            this.comboBoxModul.Name = "comboBoxModul";
            this.comboBoxModul.Size = new System.Drawing.Size(181, 21);
            this.comboBoxModul.TabIndex = 4;
            // 
            // labelModul
            // 
            this.labelModul.AutoSize = true;
            this.labelModul.Location = new System.Drawing.Point(6, 19);
            this.labelModul.Name = "labelModul";
            this.labelModul.Size = new System.Drawing.Size(36, 13);
            this.labelModul.TabIndex = 0;
            this.labelModul.Text = "Mòdul";
            // 
            // groupBoxDadesPersonals
            // 
            this.groupBoxDadesPersonals.Controls.Add(this.textBoxNom);
            this.groupBoxDadesPersonals.Controls.Add(this.textBoxCognoms);
            this.groupBoxDadesPersonals.Controls.Add(this.labelNom);
            this.groupBoxDadesPersonals.Controls.Add(this.labelCognoms);
            this.groupBoxDadesPersonals.Location = new System.Drawing.Point(11, 57);
            this.groupBoxDadesPersonals.Name = "groupBoxDadesPersonals";
            this.groupBoxDadesPersonals.Size = new System.Drawing.Size(261, 79);
            this.groupBoxDadesPersonals.TabIndex = 2;
            this.groupBoxDadesPersonals.TabStop = false;
            this.groupBoxDadesPersonals.Text = "Dades Personals";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(76, 44);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(161, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxCognoms
            // 
            this.textBoxCognoms.Location = new System.Drawing.Point(76, 19);
            this.textBoxCognoms.Name = "textBoxCognoms";
            this.textBoxCognoms.Size = new System.Drawing.Size(161, 20);
            this.textBoxCognoms.TabIndex = 2;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(8, 47);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelCognoms
            // 
            this.labelCognoms.AutoSize = true;
            this.labelCognoms.Location = new System.Drawing.Point(8, 22);
            this.labelCognoms.Name = "labelCognoms";
            this.labelCognoms.Size = new System.Drawing.Size(51, 13);
            this.labelCognoms.TabIndex = 0;
            this.labelCognoms.Text = "Cognoms";
            // 
            // dateTimePickerPeticio
            // 
            this.dateTimePickerPeticio.Location = new System.Drawing.Point(93, 20);
            this.dateTimePickerPeticio.Name = "dateTimePickerPeticio";
            this.dateTimePickerPeticio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPeticio.TabIndex = 1;
            // 
            // labelDataPeticio
            // 
            this.labelDataPeticio.AutoSize = true;
            this.labelDataPeticio.Location = new System.Drawing.Point(8, 26);
            this.labelDataPeticio.Name = "labelDataPeticio";
            this.labelDataPeticio.Size = new System.Drawing.Size(79, 13);
            this.labelDataPeticio.TabIndex = 0;
            this.labelDataPeticio.Text = "Data de petició";
            // 
            // groupBoxResum
            // 
            this.groupBoxResum.Controls.Add(this.textBoxResum);
            this.groupBoxResum.Controls.Add(this.buttonEliminarTot);
            this.groupBoxResum.Controls.Add(this.buttonEliminarSelec);
            this.groupBoxResum.Location = new System.Drawing.Point(12, 341);
            this.groupBoxResum.Name = "groupBoxResum";
            this.groupBoxResum.Size = new System.Drawing.Size(551, 144);
            this.groupBoxResum.TabIndex = 1;
            this.groupBoxResum.TabStop = false;
            this.groupBoxResum.Text = "Resum";
            // 
            // textBoxResum
            // 
            this.textBoxResum.Location = new System.Drawing.Point(7, 50);
            this.textBoxResum.Multiline = true;
            this.textBoxResum.Name = "textBoxResum";
            this.textBoxResum.Size = new System.Drawing.Size(502, 88);
            this.textBoxResum.TabIndex = 15;
            // 
            // buttonEliminarTot
            // 
            this.buttonEliminarTot.Location = new System.Drawing.Point(125, 20);
            this.buttonEliminarTot.Name = "buttonEliminarTot";
            this.buttonEliminarTot.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarTot.TabIndex = 17;
            this.buttonEliminarTot.Text = "Eliminar tot";
            this.buttonEliminarTot.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarSelec
            // 
            this.buttonEliminarSelec.AutoSize = true;
            this.buttonEliminarSelec.Location = new System.Drawing.Point(7, 20);
            this.buttonEliminarSelec.Name = "buttonEliminarSelec";
            this.buttonEliminarSelec.Size = new System.Drawing.Size(115, 23);
            this.buttonEliminarSelec.TabIndex = 16;
            this.buttonEliminarSelec.Text = "Eliminar seleccionats";
            this.buttonEliminarSelec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 497);
            this.Controls.Add(this.groupBoxResum);
            this.Controls.Add(this.groupBoxDades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDades.ResumeLayout(false);
            this.groupBoxDades.PerformLayout();
            this.groupBoxCursInteressat.ResumeLayout(false);
            this.groupBoxCursInteressat.PerformLayout();
            this.groupBoxTornInteressat.ResumeLayout(false);
            this.groupBoxTornInteressat.PerformLayout();
            this.groupBoxCursMatriculat.ResumeLayout(false);
            this.groupBoxCursMatriculat.PerformLayout();
            this.groupBoxTornMatriculat.ResumeLayout(false);
            this.groupBoxTornMatriculat.PerformLayout();
            this.groupBoxModulProfessional.ResumeLayout(false);
            this.groupBoxModulProfessional.PerformLayout();
            this.groupBoxDadesPersonals.ResumeLayout(false);
            this.groupBoxDadesPersonals.PerformLayout();
            this.groupBoxResum.ResumeLayout(false);
            this.groupBoxResum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDades;
        private System.Windows.Forms.Label labelDataPeticio;
        private System.Windows.Forms.GroupBox groupBoxResum;
        private System.Windows.Forms.Button buttonAfegirResum;
        private System.Windows.Forms.GroupBox groupBoxCursInteressat;
        private System.Windows.Forms.GroupBox groupBoxCursMatriculat;
        private System.Windows.Forms.GroupBox groupBoxModulProfessional;
        private System.Windows.Forms.Label labelModul;
        private System.Windows.Forms.GroupBox groupBoxDadesPersonals;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCognoms;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCognoms;
        private System.Windows.Forms.DateTimePicker dateTimePickerPeticio;
        private System.Windows.Forms.GroupBox groupBoxTornInteressat;
        private System.Windows.Forms.RadioButton radioButtonTardaInteressat;
        private System.Windows.Forms.RadioButton radioButtonMatiInteressat;
        private System.Windows.Forms.Label labelTutorMatriculat;
        private System.Windows.Forms.Label labelCursMatriculat;
        private System.Windows.Forms.GroupBox groupBoxTornMatriculat;
        private System.Windows.Forms.RadioButton radioButtonTardaMatriculat;
        private System.Windows.Forms.RadioButton radioButtonMatiMatriculat;
        private System.Windows.Forms.TextBox textBoxTutorInteressat;
        private System.Windows.Forms.Label labelProfeInteressat;
        private System.Windows.Forms.Label labelTutorInteressat;
        private System.Windows.Forms.Label labelCursInteressat;
        private System.Windows.Forms.TextBox textBoxTutorMatriculat;
        private System.Windows.Forms.Label labelProfeMatriculat;
        private System.Windows.Forms.ComboBox comboBoxCursInteressat;
        private System.Windows.Forms.ComboBox comboBoxProfeMatriculat;
        private System.Windows.Forms.ComboBox comboBoxCursMatriculat;
        private System.Windows.Forms.ComboBox comboBoxModul;
        private System.Windows.Forms.TextBox textBoxResum;
        private System.Windows.Forms.Button buttonEliminarTot;
        private System.Windows.Forms.Button buttonEliminarSelec;
        private System.Windows.Forms.ComboBox comboBoxProfeInteressat;
        private System.Windows.Forms.CheckedListBox checkedListBoxUFs;
    }
}

