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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            IngresarEmpleado ingresarempleado = new IngresarEmpleado();
            ingresarempleado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();  
            CrearUsuario crearusuario = new CrearUsuario();  
            crearusuario.Show();  
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
        }
    }
}
