namespace TA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIltroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expansionHistogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecualizacionHistogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtroToolStripMenuItem,
            this.histogramaToolStripMenuItem,
            this.fIltroToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.guardarImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar Imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.filtroToolStripMenuItem.Text = "TonosGris";
            this.filtroToolStripMenuItem.Click += new System.EventHandler(this.filtroToolStripMenuItem_Click);
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.histogramaToolStripMenuItem_Click);
            // 
            // fIltroToolStripMenuItem1
            // 
            this.fIltroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expansionHistogramaToolStripMenuItem,
            this.ecualizacionHistogramaToolStripMenuItem});
            this.fIltroToolStripMenuItem1.Name = "fIltroToolStripMenuItem1";
            this.fIltroToolStripMenuItem1.Size = new System.Drawing.Size(138, 20);
            this.fIltroToolStripMenuItem1.Text = "ProcesamientoImagen";
            // 
            // expansionHistogramaToolStripMenuItem
            // 
            this.expansionHistogramaToolStripMenuItem.Name = "expansionHistogramaToolStripMenuItem";
            this.expansionHistogramaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.expansionHistogramaToolStripMenuItem.Text = "Expansion Histograma";
            this.expansionHistogramaToolStripMenuItem.Click += new System.EventHandler(this.expansionHistogramaToolStripMenuItem_Click);
            // 
            // ecualizacionHistogramaToolStripMenuItem
            // 
            this.ecualizacionHistogramaToolStripMenuItem.Name = "ecualizacionHistogramaToolStripMenuItem";
            this.ecualizacionHistogramaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ecualizacionHistogramaToolStripMenuItem.Text = "Ecualizacion Histograma";
            this.ecualizacionHistogramaToolStripMenuItem.Click += new System.EventHandler(this.ecualizacionHistogramaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 762);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TA_Grupo3";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private ToolStripMenuItem guardarImagenToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem filtroToolStripMenuItem;
        private ToolStripMenuItem histogramaToolStripMenuItem;
        private ToolStripMenuItem fIltroToolStripMenuItem1;
        private ToolStripMenuItem expansionHistogramaToolStripMenuItem;
        private ToolStripMenuItem ecualizacionHistogramaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}