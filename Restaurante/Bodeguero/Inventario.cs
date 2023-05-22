using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Restaurante
{
    public partial class Inventario : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");

        public Inventario()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            MenuBodeguero menubodeguero = new MenuBodeguero();
            menubodeguero.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }


            OracleCommand verificarComando = new OracleCommand("SELECT COUNT(*) FROM insumo WHERE nombre = :nombre", conexion);
            verificarComando.Parameters.Add(":nombre", txtnombre.Text);
            int cantidadExistente = Convert.ToInt32(verificarComando.ExecuteScalar());

            if (cantidadExistente > 0)
            {
                MessageBox.Show("El producto ya existe en la base de datos");
            }
            else
            {
                // Si el producto no existe, insertarlo
                OracleCommand comando = new OracleCommand("INSERT INTO insumo (nombre, descripcion, cantidad) VALUES (:nombre, :descripcion, :cantidad)", conexion);
                comando.Parameters.Add(":nombre", txtnombre.Text);
                comando.Parameters.Add(":descripcion", txtdescripcion.Text);
                comando.Parameters.Add(":cantidad", Convert.ToInt32(txtcantidad.Text));

                int filasInsertadas = comando.ExecuteNonQuery();
                if (filasInsertadas > 0)
                {
                    MessageBox.Show("Producto agregado correctamente");
                }
                else
                {
                    MessageBox.Show("El producto no se pudo agregar");
                }
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtcantidad.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios");
                return;
            }

            OracleCommand comandoBusqueda = new OracleCommand("SELECT COUNT(*) FROM insumo WHERE nombre = :nombre", conexion);
            comandoBusqueda.Parameters.Add(":nombre", txtnombre.Text);

            int numInsumos = Convert.ToInt32(comandoBusqueda.ExecuteScalar());

            if (numInsumos == 0)
            {
                MessageBox.Show("El insumo con nombre " + txtnombre.Text + " no existe en la base de datos");
                return;
            }

            OracleCommand comando = new OracleCommand("UPDATE insumo SET cantidad = :cantidad WHERE nombre = :nombre", conexion);
            comando.Parameters.Add(":cantidad", Convert.ToInt32(txtcantidad.Text));
            comando.Parameters.Add(":nombre", txtnombre.Text);

            int filasActualizadas = comando.ExecuteNonQuery();
            if (filasActualizadas > 0)
            {
                MessageBox.Show("Producto actualizado correctamente");
            }
            else
            {
                MessageBox.Show("El producto no se pudo actualizar");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios");
                return;
            }

            OracleCommand comandoBusqueda = new OracleCommand("SELECT COUNT(*) FROM insumo WHERE nombre = :nombre", conexion);
            comandoBusqueda.Parameters.Add(":nombre", txtnombre.Text);

            int numInsumos = Convert.ToInt32(comandoBusqueda.ExecuteScalar());

            if (numInsumos == 0)
            {
                MessageBox.Show("El insumo con nombre " + txtnombre.Text + " no existe en la base de datos");
                return;
            }

            OracleCommand comando = new OracleCommand("DELETE FROM insumo WHERE nombre = :nombre", conexion);
            comando.Parameters.Add(":nombre", txtnombre.Text);

            int filasEliminadas = comando.ExecuteNonQuery();
            if (filasEliminadas > 0)
            {
                MessageBox.Show("Producto eliminado correctamente");
            }
            else
            {
                MessageBox.Show("El producto no se pudo eliminar");
            }
        }
    }
    
}
