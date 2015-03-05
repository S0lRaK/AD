namespace Cinèfil
{
    partial class FormInici
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dadesGeneralsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipusDePaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadesGeneralsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dadesGeneralsToolStripMenuItem
            // 
            this.dadesGeneralsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipusDePaperToolStripMenuItem,
            this.temesToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortirToolStripMenuItem});
            this.dadesGeneralsToolStripMenuItem.Name = "dadesGeneralsToolStripMenuItem";
            this.dadesGeneralsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dadesGeneralsToolStripMenuItem.Text = "Dades generals";
            // 
            // tipusDePaperToolStripMenuItem
            // 
            this.tipusDePaperToolStripMenuItem.Name = "tipusDePaperToolStripMenuItem";
            this.tipusDePaperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipusDePaperToolStripMenuItem.Text = "Tipus de paper";
            this.tipusDePaperToolStripMenuItem.Click += new System.EventHandler(this.tipusDePaperToolStripMenuItem_Click);
            // 
            // temesToolStripMenuItem
            // 
            this.temesToolStripMenuItem.Name = "temesToolStripMenuItem";
            this.temesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temesToolStripMenuItem.Text = "Temes";
            this.temesToolStripMenuItem.Click += new System.EventHandler(this.temesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            // 
            // FormInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInici";
            this.Text = "Cinèfil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dadesGeneralsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipusDePaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
    }
}

