namespace LeerExcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_patch = new System.Windows.Forms.TextBox();
            this.textBox_sheet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnivel = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnivel2 = new System.Windows.Forms.ComboBox();
            this.btnexportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nombre Tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_patch
            // 
            this.textBox_patch.Location = new System.Drawing.Point(123, 53);
            this.textBox_patch.Name = "textBox_patch";
            this.textBox_patch.Size = new System.Drawing.Size(239, 20);
            this.textBox_patch.TabIndex = 3;
            this.textBox_patch.TextChanged += new System.EventHandler(this.textBox_patch_TextChanged);
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Location = new System.Drawing.Point(123, 97);
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.Size = new System.Drawing.Size(239, 20);
            this.textBox_sheet.TabIndex = 4;
            this.textBox_sheet.TextChanged += new System.EventHandler(this.textBox_sheet_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxSubnivel
            // 
            this.comboBoxSubnivel.FormattingEnabled = true;
            this.comboBoxSubnivel.Location = new System.Drawing.Point(179, 148);
            this.comboBoxSubnivel.Name = "comboBoxSubnivel";
            this.comboBoxSubnivel.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSubnivel.TabIndex = 7;
            this.comboBoxSubnivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnivel_SelectedIndexChanged);
            // 
            // comboBoxSubnivel2
            // 
            this.comboBoxSubnivel2.FormattingEnabled = true;
            this.comboBoxSubnivel2.Location = new System.Drawing.Point(363, 148);
            this.comboBoxSubnivel2.Name = "comboBoxSubnivel2";
            this.comboBoxSubnivel2.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSubnivel2.TabIndex = 8;
            this.comboBoxSubnivel2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnivel2_SelectedIndexChanged);
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(621, 213);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(117, 23);
            this.btnexportar.TabIndex = 11;
            this.btnexportar.Text = "Convertir a archivo texto";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Direccion de Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de hoja";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(55, 187);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(207, 20);
            this.txtbuscar.TabIndex = 14;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buscar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 20);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 363);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.comboBoxSubnivel2);
            this.Controls.Add(this.comboBoxSubnivel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_sheet);
            this.Controls.Add(this.textBox_patch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_patch;
        private System.Windows.Forms.TextBox textBox_sheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSubnivel;
        private System.Windows.Forms.ComboBox comboBoxSubnivel2;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

