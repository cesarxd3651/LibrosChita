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
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtver = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_patch
            // 
            this.textBox_patch.Location = new System.Drawing.Point(173, 39);
            this.textBox_patch.Name = "textBox_patch";
            this.textBox_patch.Size = new System.Drawing.Size(239, 20);
            this.textBox_patch.TabIndex = 3;
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Location = new System.Drawing.Point(173, 85);
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.Size = new System.Drawing.Size(239, 20);
            this.textBox_sheet.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxSubnivel
            // 
            this.comboBoxSubnivel.FormattingEnabled = true;
            this.comboBoxSubnivel.Location = new System.Drawing.Point(192, 128);
            this.comboBoxSubnivel.Name = "comboBoxSubnivel";
            this.comboBoxSubnivel.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSubnivel.TabIndex = 7;
            this.comboBoxSubnivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnivel_SelectedIndexChanged);
            // 
            // comboBoxSubnivel2
            // 
            this.comboBoxSubnivel2.FormattingEnabled = true;
            this.comboBoxSubnivel2.Location = new System.Drawing.Point(376, 128);
            this.comboBoxSubnivel2.Name = "comboBoxSubnivel2";
            this.comboBoxSubnivel2.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSubnivel2.TabIndex = 8;
            this.comboBoxSubnivel2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubnivel2_SelectedIndexChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(659, 155);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtver
            // 
            this.txtver.Location = new System.Drawing.Point(646, 202);
            this.txtver.Name = "txtver";
            this.txtver.Size = new System.Drawing.Size(100, 20);
            this.txtver.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 317);
            this.Controls.Add(this.txtver);
            this.Controls.Add(this.btneliminar);
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
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtver;
    }
}

