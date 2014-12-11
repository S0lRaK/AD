namespace ExploradorArxius
{
    partial class FormExplorador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorador));
            this.listViewExplorador = new System.Windows.Forms.ListView();
            this.columnHeaderNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListExplorador = new System.Windows.Forms.ImageList(this.components);
            this.treeViewExplorador = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listViewExplorador
            // 
            this.listViewExplorador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNom,
            this.columnHeaderData,
            this.columnHeaderMida});
            this.listViewExplorador.Location = new System.Drawing.Point(318, 12);
            this.listViewExplorador.Name = "listViewExplorador";
            this.listViewExplorador.Size = new System.Drawing.Size(566, 357);
            this.listViewExplorador.SmallImageList = this.imageListExplorador;
            this.listViewExplorador.TabIndex = 0;
            this.listViewExplorador.UseCompatibleStateImageBehavior = false;
            this.listViewExplorador.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Nom";
            this.columnHeaderNom.Width = 81;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data de modificació";
            this.columnHeaderData.Width = 118;
            // 
            // columnHeaderMida
            // 
            this.columnHeaderMida.Text = "Mida";
            // 
            // imageListExplorador
            // 
            this.imageListExplorador.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListExplorador.ImageStream")));
            this.imageListExplorador.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListExplorador.Images.SetKeyName(0, "file.png");
            this.imageListExplorador.Images.SetKeyName(1, "Folder.png");
            this.imageListExplorador.Images.SetKeyName(2, "folder_open.png");
            // 
            // treeViewExplorador
            // 
            this.treeViewExplorador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.treeViewExplorador.ImageKey = "Folder.png";
            this.treeViewExplorador.ImageList = this.imageListExplorador;
            this.treeViewExplorador.Location = new System.Drawing.Point(12, 12);
            this.treeViewExplorador.Name = "treeViewExplorador";
            this.treeViewExplorador.SelectedImageKey = "folder_open.png";
            this.treeViewExplorador.Size = new System.Drawing.Size(300, 357);
            this.treeViewExplorador.TabIndex = 1;
            // 
            // FormExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 381);
            this.Controls.Add(this.treeViewExplorador);
            this.Controls.Add(this.listViewExplorador);
            this.Name = "FormExplorador";
            this.Text = "Explorador d\'Arxius";
            this.Load += new System.EventHandler(this.FormExplorador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewExplorador;
        private System.Windows.Forms.TreeView treeViewExplorador;
        private System.Windows.Forms.ImageList imageListExplorador;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderMida;
    }
}

