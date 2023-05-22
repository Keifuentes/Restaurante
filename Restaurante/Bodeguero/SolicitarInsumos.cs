using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Restaurante.Bodeguero
{
    public partial class SolicitarInsumos : Form
    {
        public SolicitarInsumos()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();

            MenuBodeguero menubodeguero = new MenuBodeguero();


            menubodeguero.Show();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            // Credenciales de la cuenta de correo electrónico
            var username = "pruebaportafolio2023@gmail.com"; // Reemplaza con tu correo electrónico
            var password = "fleolwvhjcszypfc"; // Reemplaza con tu contraseña

            // Detalles del servidor SMTP de Gmail
            var smtp_server = "smtp.gmail.com";
            var smtp_port = 587;

            // Detalles del correo electrónico
            var from_addr = "tucuenta@gmail.com"; // Reemplaza con tu correo electrónico
            var to_addr = txtcorreo.Text; // Reemplaza "correo_textbox" con el nombre del cuadro de texto que contiene el correo electrónico del destinatario
            var subject = "Solicitud de Insumos";
            var body = txtcuerpo.Text; // Reemplaza "cuerpo_textbox" con el nombre del cuadro de texto que contiene el cuerpo del correo electrónico

            // Creación del mensaje
            var msg = new MailMessage(from_addr, to_addr, subject, body);

            // Creación del objeto SmtpClient
            var smtp_client = new SmtpClient(smtp_server, smtp_port);
            smtp_client.EnableSsl = true;
            smtp_client.Credentials = new NetworkCredential(username, password);

            try
            {
                // Envío del correo electrónico
                smtp_client.Send(msg);

                // Muestra una ventana emergente indicando que el correo se envió correctamente
                MessageBox.Show("Correo enviado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra una ventana emergente indicando que el correo no se pudo enviar
                MessageBox.Show($"No se pudo enviar el correo. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
