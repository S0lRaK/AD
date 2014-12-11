namespace base_datos
{
    partial class Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCicles = new System.Windows.Forms.ComboBox();
            this.labelCicles = new System.Windows.Forms.Label();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCicles
            // 
            this.comboBoxCicles.FormattingEnabled = true;
            this.comboBoxCicles.Location = new System.Drawing.Point(68, 17);
            this.comboBoxCicles.Name = "comboBoxCicles";
            this.comboBoxCicles.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCicles.TabIndex = 0;
            this.comboBoxCicles.SelectedIndexChanged += new System.EventHandler(this.comboBoxCicles_SelectedIndexChanged);
            // 
            // labelCicles
            // 
            this.labelCicles.AutoSize = true;
            this.labelCicles.Location = new System.Drawing.Point(13, 20);
            this.labelCicles.Name = "labelCicles";
            this.labelCicles.Size = new System.Drawing.Size(35, 13);
            this.labelCicles.TabIndex = 1;
            this.labelCicles.Text = "Cicles";
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(16, 80);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(543, 150);
            this.dataGridViewCursos.TabIndex = 2;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 261);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.labelCicles);
            this.Controls.Add(this.comboBoxCicles);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCicles;
        private System.Windows.Forms.Label labelCicles;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
    }
}