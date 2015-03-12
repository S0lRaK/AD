namespace DataSetDAM2A
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCicles = new System.Windows.Forms.ComboBox();
            this.bindingSourceCicles = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAulacep = new DataSetDAM2A.DataSetAulacep();
            this.ciclesTableAdapter = new DataSetDAM2A.DataSetAulacepTableAdapters.ciclesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceCursos = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new DataSetDAM2A.DataSetAulacepTableAdapters.cursosTableAdapter();
            this.bindingSourceCiclesGrid = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAulacep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiclesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cicles";
            // 
            // comboBoxCicles
            // 
            this.comboBoxCicles.DataSource = this.bindingSourceCicles;
            this.comboBoxCicles.DisplayMember = "codi";
            this.comboBoxCicles.FormattingEnabled = true;
            this.comboBoxCicles.Location = new System.Drawing.Point(106, 22);
            this.comboBoxCicles.Name = "comboBoxCicles";
            this.comboBoxCicles.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCicles.TabIndex = 1;
            this.comboBoxCicles.ValueMember = "id";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codiDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn,
            this.idcicleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceCursos;
            this.dataGridView1.Location = new System.Drawing.Point(38, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // bindingSourceCursos
            // 
            this.bindingSourceCursos.DataMember = "cursos";
            this.bindingSourceCursos.DataSource = this.dataSetAulacep;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceCiclesGrid
            // 
            this.bindingSourceCiclesGrid.DataMember = "cicles";
            this.bindingSourceCiclesGrid.DataSource = this.dataSetAulacep;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codiDataGridViewTextBoxColumn
            // 
            this.codiDataGridViewTextBoxColumn.DataPropertyName = "codi";
            this.codiDataGridViewTextBoxColumn.HeaderText = "Codi";
            this.codiDataGridViewTextBoxColumn.Name = "codiDataGridViewTextBoxColumn";
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "Descripció";
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            // 
            // idcicleDataGridViewTextBoxColumn
            // 
            this.idcicleDataGridViewTextBoxColumn.DataPropertyName = "id_cicle";
            this.idcicleDataGridViewTextBoxColumn.DataSource = this.bindingSourceCiclesGrid;
            this.idcicleDataGridViewTextBoxColumn.DisplayMember = "codi";
            this.idcicleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idcicleDataGridViewTextBoxColumn.HeaderText = "Cicle";
            this.idcicleDataGridViewTextBoxColumn.Name = "idcicleDataGridViewTextBoxColumn";
            this.idcicleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcicleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcicleDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(459, 13);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 262);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCicles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAulacep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiclesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCicles;
        private System.Windows.Forms.BindingSource bindingSourceCicles;
        private DataSetAulacep dataSetAulacep;
        private DataSetAulacepTableAdapters.ciclesTableAdapter ciclesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceCursos;
        private DataSetAulacepTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceCiclesGrid;
        private System.Windows.Forms.Button buttonGuardar;
    }
}

