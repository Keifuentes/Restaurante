using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Restaurante.Bodeguero
{

    public partial class VerStock : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");

        public VerStock()
        {
            InitializeComponent();
        }

        private void VerStock_Load(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();

                // Realizar la consulta para obtener el inventario
                OracleCommand comando = new OracleCommand("SELECT * FROM INSUMO", conexion);
                OracleDataAdapter adaptador = new OracleDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Recorrer los registros del inventario y verificar si hay algún producto con stock bajo
                bool hayStockBajo = false;
                foreach (DataRow row in dt.Rows)
                {
                    int cantidadActual = Convert.ToInt32(row["Cantidad"]);
                    int cantidadMinima = 20; // Esta sería la cantidad mínima para que no haya stock bajo, puedes ajustarla según tus necesidades

                    if (cantidadActual < cantidadMinima)
                    {
                        hayStockBajo = true;
                        break;
                    }
                }

                // Mostrar una ventana emergente si hay stock bajo
                if (hayStockBajo)
                {
                    MessageBox.Show("Hay productos con stock bajo. Por favor revisa el inventario.", "Falta de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Actualizar el DataGridView con los datos del inventario
                dataGridView1.DataSource = dt;
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();

            MenuBodeguero menubodeguero = new MenuBodeguero();


            menubodeguero.Show();
        }
    }
}
