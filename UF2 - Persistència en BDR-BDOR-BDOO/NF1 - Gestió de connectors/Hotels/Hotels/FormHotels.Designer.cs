namespace Hotels
{
    partial class FormHotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotels));
            this.toolStripEines = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSortir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNouHotel = new System.Windows.Forms.ToolStripButton();
            this.labelCiutat = new System.Windows.Forms.Label();
            this.comboBoxCiutat = new System.Windows.Forms.ComboBox();
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.toolStripEines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEines
            // 
            this.toolStripEines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNouHotel,
            this.toolStripButtonSortir});
            this.toolStripEines.Location = new System.Drawing.Point(0, 0);
            this.toolStripEines.Name = "toolStripEines";
            this.toolStripEines.Size = new System.Drawing.Size(599, 25);
            this.toolStripEines.TabIndex = 0;
            this.toolStripEines.Text = "toolStrip1";
            // 
            // toolStripButtonSortir
            // 
            this.toolStripButtonSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSortir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSortir.Image")));
            this.toolStripButtonSortir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSortir.Name = "toolStripButtonSortir";
            this.toolStripButtonSortir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSortir.Text = "Sortir";
            // 
            // toolStripButtonNouHotel
            // 
            this.toolStripButtonNouHotel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNouHotel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNouHotel.Image")));
            this.toolStripButtonNouHotel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNouHotel.Name = "toolStripButtonNouHotel";
            this.toolStripButtonNouHotel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNouHotel.Text = "Nou hotel";
            // 
            // labelCiutat
            // 
            this.labelCiutat.AutoSize = true;
            this.labelCiutat.Location = new System.Drawing.Point(12, 37);
            this.labelCiutat.Name = "labelCiutat";
            this.labelCiutat.Size = new System.Drawing.Size(34, 13);
            this.labelCiutat.TabIndex = 1;
            this.labelCiutat.Text = "Ciutat";
            // 
            // comboBoxCiutat
            // 
            this.comboBoxCiutat.FormattingEnabled = true;
            this.comboBoxCiutat.Location = new System.Drawing.Point(65, 34);
            this.comboBoxCiutat.Name = "comboBoxCiutat";
            this.comboBoxCiutat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiutat.TabIndex = 2;
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Location = new System.Drawing.Point(15, 79);
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.ReadOnly = true;
            this.dataGridViewHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHotels.Size = new System.Drawing.Size(572, 170);
            this.dataGridViewHotels.TabIndex = 3;
            // 
            // FormHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.dataGridViewHotels);
            this.Controls.Add(this.comboBoxCiutat);
            this.Controls.Add(this.labelCiutat);
            this.Controls.Add(this.toolStripEines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHotels";
            this.Text = "Hotels";
            this.Load += new System.EventHandler(this.FormHotels_Load);
            this.toolStripEines.ResumeLayout(false);
            this.toolStripEines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEines;
        private System.Windows.Forms.ToolStripButton toolStripButtonSortir;
        private System.Windows.Forms.ToolStripButton toolStripButtonNouHotel;
        private System.Windows.Forms.Label labelCiutat;
        private System.Windows.Forms.ComboBox comboBoxCiutat;
        private System.Windows.Forms.DataGridView dataGridViewHotels;
    }
}