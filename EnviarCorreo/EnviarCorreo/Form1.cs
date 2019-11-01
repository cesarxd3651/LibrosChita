using Emailer;
using System;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Windows.Forms;

namespace EnviarCorreo
{
    public partial class Form1 : Form
    {
        private string correoApp { get; set; }

        public Form1()
        {

            InitializeComponent();
            SmtpSection smtp = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
            correoApp = smtp.From;
            txtorigen.Text = correoApp;
        }

      

        private void LimpiarFormulario()
        {
            txtorigen.Text = string.Empty;
            txtpara.Text = string.Empty;
            txtmensaje.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            var smtp = new SmtpClient();
            EmailSender emailSender = new EmailSender(smtp, correoApp);
            emailSender.SendEmailAsync(txtorigen.Text, txtpara.Text, txtmensaje.Text);
            MessageBox.Show("Correo Enviado correctamente");
            LimpiarFormulario();
        }
    }
}
