using Restaurante.Bodeguero;
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
    public partial class MenuBodeguero : Form
    {
        public MenuBodeguero()
        {
            InitializeComponent();
        }

        private void MenuBodeguero_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Close();

            Inventario inventario = new Inventario();

            
            inventario.Show();
        }

        private void btnverstock_Click(object sender, EventArgs e)
        {
            this.Close();

            VerStock verstock = new VerStock();


            verstock.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Close();

            SolicitarInsumos solicitarinsumos = new SolicitarInsumos();


            solicitarinsumos.Show();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();

            InicioSesion inicioSesion = new InicioSesion();


            inicioSesion.Show();
        }
    }
}
