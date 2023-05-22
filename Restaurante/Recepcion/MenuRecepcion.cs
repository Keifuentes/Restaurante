using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class MenuRecepcion : Form
    {
        public MenuRecepcion()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            IngresoCliente ingresocliente = new IngresoCliente();
            ingresocliente.Show();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
        }

        private void btnorden_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            Orden menuorden = new Orden();
            menuorden.Show();
        }
    }
}
