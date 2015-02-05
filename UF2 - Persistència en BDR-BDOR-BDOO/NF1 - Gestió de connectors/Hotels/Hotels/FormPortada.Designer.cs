namespace Hotels
{
    partial class FormPortada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortada));
            this.menuStripPortada = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxFons = new System.Windows.Forms.PictureBox();
            this.menuStripPortada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFons)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPortada
            // 
            this.menuStripPortada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem});
            this.menuStripPortada.Location = new System.Drawing.Point(0, 0);
            this.menuStripPortada.Name = "menuStripPortada";
            this.menuStripPortada.Size = new System.Drawing.Size(602, 24);
            this.menuStripPortada.TabIndex = 0;
            this.menuStripPortada.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelsToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // hotelsToolStripMenuItem
            // 
            this.hotelsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelsToolStripMenuItem.Image")));
            this.hotelsToolStripMenuItem.Name = "hotelsToolStripMenuItem";
            this.hotelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hotelsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hotelsToolStripMenuItem.Text = "Hotels";
            this.hotelsToolStripMenuItem.Click += new System.EventHandler(this.hotelsToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortirToolStripMenuItem.Image")));
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // pictureBoxFons
            // 
            this.pictureBoxFons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFons.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFons.Image")));
            this.pictureBoxFons.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxFons.Name = "pictureBoxFons";
            this.pictureBoxFons.Size = new System.Drawing.Size(602, 308);
            this.pictureBoxFons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFons.TabIndex = 1;
            this.pictureBoxFons.TabStop = false;
            // 
            // FormPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 332);
            this.Controls.Add(this.pictureBoxFons);
            this.Controls.Add(this.menuStripPortada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPortada;
            this.Name = "FormPortada";
            this.Text = "Aplicació Hotels";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripPortada.ResumeLayout(false);
            this.menuStripPortada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPortada;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxFons;
    }
}

