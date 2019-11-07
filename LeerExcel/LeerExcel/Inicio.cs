using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerExcel
{
    public partial class Inicio : Form
    {

        public string directorio { get; set; }
        public string hoja { get; set; }
        public Inicio()
        {
            InitializeComponent();
        }

        private void mostrarDatosDeExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();   
            mm.Show();
        }

        private void guardarDatosDeExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltrarPorColumnas fil = new FiltrarPorColumnas();
            fil.Show();
        }

        private void btndireccion_Click(object sender, EventArgs e)
        {

            
        }

        private void exportarDatosDeExcelATxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
