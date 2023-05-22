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

namespace Restaurante
{
    public partial class Orden : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");

        public Orden()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            
            OracleCommand comandoVerificarMesa = new OracleCommand("SELECT COUNT(*) FROM CLIENTE WHERE MESA_ASIGNADA = :numeroMesa", conexion);
            comandoVerificarMesa.Parameters.Add(":numeroMesa", txtmesa.Text);
            int countMesa = Convert.ToInt32(comandoVerificarMesa.ExecuteScalar());

            if (countMesa == 0)
            {
                MessageBox.Show("La mesa no existe en la base de datos.");
                return;
            }

            OracleCommand comando = new OracleCommand("INSERT INTO orden (nombre_plato, nombre_cliente) VALUES (:nombrePlato, :nombrecliente)", conexion);
            comando.Parameters.Add(":nombrePlato", txtorden.Text);
            comando.Parameters.Add(":nombrecliente", txtnombrecliente.Text);

            int filasInsertadas = comando.ExecuteNonQuery();
            if (filasInsertadas > 0)
            {
                MessageBox.Show("Orden agregada correctamente");
            }
            else
            {
                MessageBox.Show("La orden no se pudo agregar");
            }
        }
    }
}
