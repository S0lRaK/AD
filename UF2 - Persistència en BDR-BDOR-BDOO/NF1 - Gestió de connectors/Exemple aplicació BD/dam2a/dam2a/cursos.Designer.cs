namespace dam2a
{
    partial class cursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCicles = new System.Windows.Forms.ComboBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cicles";
            // 
            // comboBoxCicles
            // 
            this.comboBoxCicles.FormattingEnabled = true;
            this.comboBoxCicles.Location = new System.Drawing.Point(112, 17);
            this.comboBoxCicles.Name = "comboBoxCicles";
            this.comboBoxCicles.Size = new System.Drawing.Size(240, 21);
            this.comboBoxCicles.TabIndex = 1;
            this.comboBoxCicles.SelectedIndexChanged += new System.EventHandler(this.comboBoxCicles_SelectedIndexChanged);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(519, 150);
            this.dataGridViewCursos.TabIndex = 2;
            // 
            // cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 234);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.comboBoxCicles);
            this.Controls.Add(this.label1);
            this.Name = "cursos";
            this.Text = "cursos";
            this.Load += new System.EventHandler(this.cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCicles;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
    }
}