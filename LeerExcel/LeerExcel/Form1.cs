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

namespace LeerExcel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_patch.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT PRINCIPAL from [" + textBox_sheet.Text + "$] ",conn);
            try
            {
            

               DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                comboBox1.DisplayMember="PRINCIPAL";
                comboBox1.DataSource = dt; //dataGridView1.DataSource = dt;
                
            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT SUBNIVEL1 from [" + textBox_sheet.Text + "$] where PRINCIPAL LIKE '%"+comboBox1.Text+"' ", conn);

            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                comboBoxSubnivel.DisplayMember = "SUBNIVEL1";
                comboBoxSubnivel.DataSource = dt;
                //myDataAdapter.Fill(dt);
                //dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }


        }

        private void comboBoxSubnivel_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT SUBNIVEL2 from [" + textBox_sheet.Text + "$] where SUBNIVEL1 LIKE '%" + comboBoxSubnivel.Text + "' ", conn);

            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                comboBoxSubnivel2.DisplayMember = "SUBNIVEL2";
                comboBoxSubnivel2.DataSource = dt;
                //myDataAdapter.Fill(dt);
                //dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }
        }

        private void comboBoxSubnivel2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select Ord,titulo,autor,isbnissn,Idioma,Edicion,Editorial,anio,Ejemplar,Tipo from [" + textBox_sheet.Text + "$] where SUBNIVEL2 LIKE '%" + comboBoxSubnivel2.Text + "' ", conn);

            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

               

                string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(PatchConn);
                        conn.Open();
                        using (OleDbCommand cmd = conn.CreateCommand())
                        {
                        String ord =dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                        //cmd.CommandText = "DELETE FROM [" + textBox_sheet.Text + "$] WHERE Ord='" + ord + "'";
                        cmd.CommandText = "DELETE FROM [" + textBox_sheet.Text + "$] WHERE Ord like '@par1'";
                        cmd.Parameters.AddWithValue("@par1", ord);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos eliminados Correctamente...");
                        }
                        conn.Close();
                

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar bebecito BRRRRR");
            }
        }
    }
}
