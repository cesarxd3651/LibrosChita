using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MasterPadre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        String cn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:/Users/USP/source/repos/MasterPadre/archivo.xlsx";Extended Properties=/"Excel 12.0 Xml;HDR=YES;IMEX=1\";";
        public DataTable Datos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ORD");
            dt.Columns.Add("Principal");
            dt.Columns.Add("Sub Nivel 1");
            dt.Columns.Add("Sub Nivel 2");
            dt.Columns.Add("Titulo");
            dt.Columns.Add("Autor");
            dt.Columns.Add("isbn/issn");
            dt.Columns.Add("Idioma");
            dt.Columns.Add("Edición");
            dt.Columns.Add("Año");
            dt.Columns.Add("Ejemplar");
            dt.Columns.Add("Tipo");
            using (OleDbConnection cnn = new OleDbConnection(cn))
            {
                string sql = "SELECT *FROM [Hoja2$]";

                OleDbCommand command = new OleDbCommand(sql, cnn);

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }

        public void CargarDatos()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Datos();
        }
    }
}
