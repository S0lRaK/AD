namespace Cinèfil
{
    partial class FormTipusPaper
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
            this.toolStrip_tipusPaper = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Alta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Cerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Gravar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Sortir = new System.Windows.Forms.ToolStripButton();
            this.groupBox_criterisCerca = new System.Windows.Forms.GroupBox();
            this.textBox_criterisCerca = new System.Windows.Forms.TextBox();
            this.label_criterisCerca = new System.Windows.Forms.Label();
            this.groupBox_tipusPaper = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip_tipusPaper.SuspendLayout();
            this.groupBox_criterisCerca.SuspendLayout();
            this.groupBox_tipusPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_tipusPaper
            // 
            this.toolStrip_tipusPaper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Alta,
            this.toolStripButton_Cerca,
            this.toolStripButton_Gravar,
            this.toolStripSeparator1,
            this.toolStripButton_Sortir});
            this.toolStrip_tipusPaper.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_tipusPaper.Name = "toolStrip_tipusPaper";
            this.toolStrip_tipusPaper.Size = new System.Drawing.Size(556, 25);
            this.toolStrip_tipusPaper.TabIndex = 0;
            this.toolStrip_tipusPaper.Text = "toolStrip1";
            // 
            // toolStripButton_Alta
            // 
            this.toolStripButton_Alta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Alta.Image = global::Cinèfil.Properties.Resources.new_32;
            this.toolStripButton_Alta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Alta.Name = "toolStripButton_Alta";
            this.toolStripButton_Alta.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Alta.Text = "toolStripButton1";
            this.toolStripButton_Alta.Click += new System.EventHandler(this.toolStripButton_Alta_Click);
            // 
            // toolStripButton_Cerca
            // 
            this.toolStripButton_Cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Cerca.Image = global::Cinèfil.Properties.Resources.search_32;
            this.toolStripButton_Cerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Cerca.Name = "toolStripButton_Cerca";
            this.toolStripButton_Cerca.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Cerca.Text = "toolStripButton2";
            this.toolStripButton_Cerca.Click += new System.EventHandler(this.toolStripButton_Cerca_Click);
            // 
            // toolStripButton_Gravar
            // 
            this.toolStripButton_Gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Gravar.Image = global::Cinèfil.Properties.Resources.document_save_32;
            this.toolStripButton_Gravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Gravar.Name = "toolStripButton_Gravar";
            this.toolStripButton_Gravar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Gravar.Text = "toolStripButton3";
            this.toolStripButton_Gravar.Click += new System.EventHandler(this.toolStripButton_Gravar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Sortir
            // 
            this.toolStripButton_Sortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Sortir.Image = global::Cinèfil.Properties.Resources.application_exit_32;
            this.toolStripButton_Sortir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sortir.Name = "toolStripButton_Sortir";
            this.toolStripButton_Sortir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Sortir.Text = "toolStripButton4";
            this.toolStripButton_Sortir.Click += new System.EventHandler(this.toolStripButton_Sortir_Click);
            // 
            // groupBox_criterisCerca
            // 
            this.groupBox_criterisCerca.Controls.Add(this.textBox_criterisCerca);
            this.groupBox_criterisCerca.Controls.Add(this.label_criterisCerca);
            this.groupBox_criterisCerca.Location = new System.Drawing.Point(13, 39);
            this.groupBox_criterisCerca.Name = "groupBox_criterisCerca";
            this.groupBox_criterisCerca.Size = new System.Drawing.Size(531, 91);
            this.groupBox_criterisCerca.TabIndex = 1;
            this.groupBox_criterisCerca.TabStop = false;
            this.groupBox_criterisCerca.Text = "Criteris de cerca";
            // 
            // textBox_criterisCerca
            // 
            this.textBox_criterisCerca.Location = new System.Drawing.Point(124, 43);
            this.textBox_criterisCerca.Name = "textBox_criterisCerca";
            this.textBox_criterisCerca.Size = new System.Drawing.Size(339, 20);
            this.textBox_criterisCerca.TabIndex = 1;
            // 
            // label_criterisCerca
            // 
            this.label_criterisCerca.AutoSize = true;
            this.label_criterisCerca.Location = new System.Drawing.Point(41, 46);
            this.label_criterisCerca.Name = "label_criterisCerca";
            this.label_criterisCerca.Size = new System.Drawing.Size(33, 13);
            this.label_criterisCerca.TabIndex = 0;
            this.label_criterisCerca.Text = "Tipus";
            // 
            // groupBox_tipusPaper
            // 
            this.groupBox_tipusPaper.Controls.Add(this.dataGridView1);
            this.groupBox_tipusPaper.Location = new System.Drawing.Point(13, 136);
            this.groupBox_tipusPaper.Name = "groupBox_tipusPaper";
            this.groupBox_tipusPaper.Size = new System.Drawing.Size(531, 223);
            this.groupBox_tipusPaper.TabIndex = 2;
            this.groupBox_tipusPaper.TabStop = false;
            this.groupBox_tipusPaper.Text = "Tipus de paper";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormTipusPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 371);
            this.Controls.Add(this.groupBox_tipusPaper);
            this.Controls.Add(this.groupBox_criterisCerca);
            this.Controls.Add(this.toolStrip_tipusPaper);
            this.Name = "FormTipusPaper";
            this.Text = "Tipus de paper";
            this.toolStrip_tipusPaper.ResumeLayout(false);
            this.toolStrip_tipusPaper.PerformLayout();
            this.groupBox_criterisCerca.ResumeLayout(false);
            this.groupBox_criterisCerca.PerformLayout();
            this.groupBox_tipusPaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_tipusPaper;
        private System.Windows.Forms.ToolStripButton toolStripButton_Alta;
        private System.Windows.Forms.ToolStripButton toolStripButton_Cerca;
        private System.Windows.Forms.ToolStripButton toolStripButton_Gravar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sortir;
        private System.Windows.Forms.GroupBox groupBox_criterisCerca;
        private System.Windows.Forms.GroupBox groupBox_tipusPaper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_criterisCerca;
        private System.Windows.Forms.Label label_criterisCerca;
    }
}