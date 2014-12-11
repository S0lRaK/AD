namespace Fitxers
{
    partial class FormFitxers
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
            this.groupBoxDirectoriOrigen = new System.Windows.Forms.GroupBox();
            this.buttonDirectoriOrigen = new System.Windows.Forms.Button();
            this.textBoxDirectoriOrigen = new System.Windows.Forms.TextBox();
            this.labelDirectoriOrigen = new System.Windows.Forms.Label();
            this.groupBoxFitxersDesti = new System.Windows.Forms.GroupBox();
            this.labelDirectoriDesti = new System.Windows.Forms.Label();
            this.groupBoxDirectoriOrigen.SuspendLayout();
            this.groupBoxFitxersDesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDirectoriOrigen
            // 
            this.groupBoxDirectoriOrigen.Controls.Add(this.buttonDirectoriOrigen);
            this.groupBoxDirectoriOrigen.Controls.Add(this.textBoxDirectoriOrigen);
            this.groupBoxDirectoriOrigen.Controls.Add(this.labelDirectoriOrigen);
            this.groupBoxDirectoriOrigen.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDirectoriOrigen.Name = "groupBoxDirectoriOrigen";
            this.groupBoxDirectoriOrigen.Size = new System.Drawing.Size(580, 100);
            this.groupBoxDirectoriOrigen.TabIndex = 0;
            this.groupBoxDirectoriOrigen.TabStop = false;
            this.groupBoxDirectoriOrigen.Text = "Directori origen";
            // 
            // buttonDirectoriOrigen
            // 
            this.buttonDirectoriOrigen.Location = new System.Drawing.Point(536, 19);
            this.buttonDirectoriOrigen.Name = "buttonDirectoriOrigen";
            this.buttonDirectoriOrigen.Size = new System.Drawing.Size(38, 21);
            this.buttonDirectoriOrigen.TabIndex = 2;
            this.buttonDirectoriOrigen.UseVisualStyleBackColor = true;
            // 
            // textBoxDirectoriOrigen
            // 
            this.textBoxDirectoriOrigen.Enabled = false;
            this.textBoxDirectoriOrigen.Location = new System.Drawing.Point(105, 20);
            this.textBoxDirectoriOrigen.Name = "textBoxDirectoriOrigen";
            this.textBoxDirectoriOrigen.Size = new System.Drawing.Size(425, 20);
            this.textBoxDirectoriOrigen.TabIndex = 1;
            // 
            // labelDirectoriOrigen
            // 
            this.labelDirectoriOrigen.AutoSize = true;
            this.labelDirectoriOrigen.Location = new System.Drawing.Point(25, 23);
            this.labelDirectoriOrigen.Name = "labelDirectoriOrigen";
            this.labelDirectoriOrigen.Size = new System.Drawing.Size(46, 13);
            this.labelDirectoriOrigen.TabIndex = 0;
            this.labelDirectoriOrigen.Text = "Directori";
            // 
            // groupBoxFitxersDesti
            // 
            this.groupBoxFitxersDesti.Controls.Add(this.labelDirectoriDesti);
            this.groupBoxFitxersDesti.Location = new System.Drawing.Point(13, 120);
            this.groupBoxFitxersDesti.Name = "groupBoxFitxersDesti";
            this.groupBoxFitxersDesti.Size = new System.Drawing.Size(580, 129);
            this.groupBoxFitxersDesti.TabIndex = 1;
            this.groupBoxFitxersDesti.TabStop = false;
            this.groupBoxFitxersDesti.Text = "Fitxers destí";
            // 
            // labelDirectoriDesti
            // 
            this.labelDirectoriDesti.AutoSize = true;
            this.labelDirectoriDesti.Location = new System.Drawing.Point(25, 25);
            this.labelDirectoriDesti.Name = "labelDirectoriDesti";
            this.labelDirectoriDesti.Size = new System.Drawing.Size(46, 13);
            this.labelDirectoriDesti.TabIndex = 0;
            this.labelDirectoriDesti.Text = "Directori";
            // 
            // FormFitxers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 261);
            this.Controls.Add(this.groupBoxFitxersDesti);
            this.Controls.Add(this.groupBoxDirectoriOrigen);
            this.Name = "FormFitxers";
            this.Text = "Fitxers de text i XML";
            this.groupBoxDirectoriOrigen.ResumeLayout(false);
            this.groupBoxDirectoriOrigen.PerformLayout();
            this.groupBoxFitxersDesti.ResumeLayout(false);
            this.groupBoxFitxersDesti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDirectoriOrigen;
        private System.Windows.Forms.GroupBox groupBoxFitxersDesti;
        private System.Windows.Forms.TextBox textBoxDirectoriOrigen;
        private System.Windows.Forms.Label labelDirectoriOrigen;
        private System.Windows.Forms.Button buttonDirectoriOrigen;
        private System.Windows.Forms.Label labelDirectoriDesti;
    }
}

