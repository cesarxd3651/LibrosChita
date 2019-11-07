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
using System.IO;

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



                string conexionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";

                int ord =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());

                //cmd.CommandText = "DELETE FROM [" + textBox_sheet.Text + "$] WHERE Ord='" + ord + "'";
                string sql2 = "DELETE FROM [" + textBox_sheet.Text + "$] WHERE Ord="+ord+"";


                OleDbConnection oledbconexion = new OleDbConnection(conexionString);

                oledbconexion.Open();

                OleDbCommand oldbcomand = new OleDbCommand();
                oldbcomand.Connection = oledbconexion;
                oldbcomand.CommandText = sql2;
                oldbcomand.ExecuteNonQuery();
                oledbconexion.Close();

                MessageBox.Show("eliminado do perlito Correctamente...");




            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo insertar datos  xq no eres nadie webon " + ex.ToString());
            }

        
    }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("C:/Exportacion.txt");
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString()+"|");
                }
            }
            writer.Close();
            MessageBox.Show("Datos exportados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
        }

        private void textBox_patch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_sheet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            try
            {

                string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_patch.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(PatchConn);
                String buscar = txtbuscar.Text;
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select * from [" + textBox_sheet.Text + "$] where titulo='"+buscar+"'", conn);


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show("No existe el nombre de la hoja" + ex.ToString());
            }
        }
    }

}
