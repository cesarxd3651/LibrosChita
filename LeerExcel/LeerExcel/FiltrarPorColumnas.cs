using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerExcel
{
    public partial class FiltrarPorColumnas : Form
    {
        public FiltrarPorColumnas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtexcel.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtexcel.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT PRINCIPAL  from [" + txthoja.Text + "$] ", conn);
            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                cboprincipal.DisplayMember = "PRINCIPAL";
                cboprincipal.DataSource = dt;//dataGridView1.DataSource = dt;

            }
            catch (Exception EX)
            {

                MessageBox.Show("No existe el nombre de la hoja" + EX.ToString());
            }
        }

        private void cboprincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtexcel.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT SUBNIVEL1 from [" + txthoja.Text + "$] where PRINCIPAL LIKE '%" + cboprincipal.Text + "' ", conn);

            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                cbosub1.DisplayMember = "SUBNIVEL1";
                cbosub1.DataSource = dt;
                //myDataAdapter.Fill(dt);
                //dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }
        }

        private void cbosub1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string PatchConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtexcel.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PatchConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("select DISTINCT SUBNIVEL2 from [" + txthoja.Text + "$] where SUBNIVEL1 LIKE '%" + cbosub1.Text + "' ", conn);

            try
            {


                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                cbosub2.DisplayMember = "SUBNIVEL2";
                cbosub2.DataSource = dt;
                //myDataAdapter.Fill(dt);
                //dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("No existe el nombre de la hoja");
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txthoja.Text!=""||txtexcel.Text!=""||textBox1.Text!=""||txttitulo.Text!=null||txtautor.Text!=null||txtisbn.Text!=null||txtidioma.Text!=null||txtedicion.Text!=null||txteditorial.Text!=null||txtanio.Text!=null||txtejemplar.Text!=null||txttipo.Text!=null)
            {

                try
                {



                    string conexionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtexcel.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                    int orden = Convert.ToInt32(textBox1.Text);
                    string principal = cboprincipal.Text;
                    string subnivel1 = cbosub1.Text;
                    string subnivel2 = cbosub2.Text;
                    string titulo = txttitulo.Text;
                    string autor = txtautor.Text;
                    string isbn = txtisbn.Text;
                    string idioma = txtidioma.Text;
                    int edicion = Convert.ToInt32(txtedicion.Text);
                    string editorial = txteditorial.Text;
                    int anio = Convert.ToInt32(txtanio.Text);
                    int ejemplar = Convert.ToInt32(txtejemplar.Text);
                    string tipo = txttipo.Text;

                    //cmd.CommandText = "DELETE FROM [" + textBox_sheet.Text + "$] WHERE Ord='" + ord + "'";
                    string sql2 = "INSERT INTO [" + txthoja.Text + "$] (Ord,PRINCIPAL,SUBNIVEL1,SUBNIVEL2,titulo,autor,isbnissn,Idioma,Edicion,Editorial,anio,Ejemplar,Tipo) Values('" + orden + "','" + principal + "','" + subnivel1 + "','" + subnivel2 + "','" + titulo + "','" + autor + "','" + isbn + "','" + idioma + "','" + edicion + "','" + editorial + "','" + anio + "','" + ejemplar + "','" + tipo + "')";


                    OleDbConnection oledbconexion = new OleDbConnection(conexionString);

                    oledbconexion.Open();

                    OleDbCommand oldbcomand = new OleDbCommand();
                    oldbcomand.Connection = oledbconexion;
                    oldbcomand.CommandText = sql2;
                    oldbcomand.ExecuteNonQuery();
                    oledbconexion.Close();

                    MessageBox.Show("Datos guardados perlito Correctamente...");




                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo insertar datos  xq no eres nadie webon " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Seleccionar Excel y nombre de la hoja");
            }
        }

        private void txtedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtejemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
