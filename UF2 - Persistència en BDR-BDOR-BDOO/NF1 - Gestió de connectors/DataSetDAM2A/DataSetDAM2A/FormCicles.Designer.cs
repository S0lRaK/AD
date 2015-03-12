namespace DataSetDAM2A
{
    partial class FormCicles
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescripció = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonModificacio = new System.Windows.Forms.Button();
            this.buttonEsborrar = new System.Windows.Forms.Button();
            this.bindingSourceCicles = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAulacep = new DataSetDAM2A.DataSetAulacep();
            this.ciclesTableAdapter = new DataSetDAM2A.DataSetAulacepTableAdapters.ciclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAulacep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(109, 5);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(218, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxCodi
            // 
            this.textBoxCodi.Location = new System.Drawing.Point(109, 31);
            this.textBoxCodi.Name = "textBoxCodi";
            this.textBoxCodi.Size = new System.Drawing.Size(218, 20);
            this.textBoxCodi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codi";
            // 
            // textBoxDescripció
            // 
            this.textBoxDescripció.Location = new System.Drawing.Point(109, 57);
            this.textBoxDescripció.Name = "textBoxDescripció";
            this.textBoxDescripció.Size = new System.Drawing.Size(218, 20);
            this.textBoxDescripció.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripció";
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(27, 100);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonAlta.TabIndex = 6;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonModificacio
            // 
            this.buttonModificacio.Location = new System.Drawing.Point(109, 100);
            this.buttonModificacio.Name = "buttonModificacio";
            this.buttonModificacio.Size = new System.Drawing.Size(75, 23);
            this.buttonModificacio.TabIndex = 7;
            this.buttonModificacio.Text = "Modificació";
            this.buttonModificacio.UseVisualStyleBackColor = true;
            this.buttonModificacio.Click += new System.EventHandler(this.buttonModificacio_Click);
            // 
            // buttonEsborrar
            // 
            this.buttonEsborrar.Location = new System.Drawing.Point(190, 100);
            this.buttonEsborrar.Name = "buttonEsborrar";
            this.buttonEsborrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEsborrar.TabIndex = 8;
            this.buttonEsborrar.Text = "Esborrar";
            this.buttonEsborrar.UseVisualStyleBackColor = true;
            this.buttonEsborrar.Click += new System.EventHandler(this.buttonEsborrar_Click);
            // 
            // bindingSourceCicles
            // 
            this.bindingSourceCicles.DataMember = "cicles";
            this.bindingSourceCicles.DataSource = this.dataSetAulacep;
            // 
            // dataSetAulacep
            // 
            this.dataSetAulacep.DataSetName = "DataSetAulacep";
            this.dataSetAulacep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciclesTableAdapter
            // 
            this.ciclesTableAdapter.ClearBeforeFill = true;
            // 
            // FormCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 141);
            this.Controls.Add(this.buttonEsborrar);
            this.Controls.Add(this.buttonModificacio);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.textBoxDescripció);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "FormCicles";
            this.Text = "FormCicles";
            this.Load += new System.EventHandler(this.FormCicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAulacep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescripció;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonModificacio;
        private System.Windows.Forms.Button buttonEsborrar;
        private System.Windows.Forms.BindingSource bindingSourceCicles;
        private DataSetAulacep dataSetAulacep;
        private DataSetAulacepTableAdapters.ciclesTableAdapter ciclesTableAdapter;
    }
}