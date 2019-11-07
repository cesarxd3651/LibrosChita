namespace LeerExcel
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosDeExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarDatosDeExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDatosDeExcelATxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatosDeExcelToolStripMenuItem,
            this.guardarDatosDeExcelToolStripMenuItem,
            this.exportarDatosDeExcelATxtToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mostrarDatosDeExcelToolStripMenuItem
            // 
            this.mostrarDatosDeExcelToolStripMenuItem.Name = "mostrarDatosDeExcelToolStripMenuItem";
            this.mostrarDatosDeExcelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mostrarDatosDeExcelToolStripMenuItem.Text = "Mostrar Datos de Excel";
            this.mostrarDatosDeExcelToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosDeExcelToolStripMenuItem_Click);
            // 
            // guardarDatosDeExcelToolStripMenuItem
            // 
            this.guardarDatosDeExcelToolStripMenuItem.Name = "guardarDatosDeExcelToolStripMenuItem";
            this.guardarDatosDeExcelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.guardarDatosDeExcelToolStripMenuItem.Text = "Guardar Datos de excel";
            this.guardarDatosDeExcelToolStripMenuItem.Click += new System.EventHandler(this.guardarDatosDeExcelToolStripMenuItem_Click);
            // 
            // exportarDatosDeExcelATxtToolStripMenuItem
            // 
            this.exportarDatosDeExcelATxtToolStripMenuItem.Name = "exportarDatosDeExcelATxtToolStripMenuItem";
            this.exportarDatosDeExcelATxtToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exportarDatosDeExcelATxtToolStripMenuItem.Text = "Exportar Datos de Excel a txt";
            this.exportarDatosDeExcelATxtToolStripMenuItem.Click += new System.EventHandler(this.exportarDatosDeExcelATxtToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosDeExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarDatosDeExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDatosDeExcelATxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}