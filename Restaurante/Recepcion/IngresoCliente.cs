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
    public partial class IngresoCliente : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");


        public IngresoCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            MenuRecepcion menurecepcion = new MenuRecepcion();
            menurecepcion.Show();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

           // Verificar si la mesa ya existe en la tabla de clientes
            OracleCommand comandoSelect = new OracleCommand("SELECT COUNT(*) FROM cliente WHERE mesa_asignada = :mesa", conexion);
            comandoSelect.Parameters.Add(":mesa", txtmesa.Text);

            int count = Convert.ToInt32(comandoSelect.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("La mesa ya se encuentra asignada a otro cliente, por favor ingrese una mesa diferente.");
                return;
            }

            // Insertar el cliente en la tabla de clientes
            OracleCommand comandoInsert = new OracleCommand("INSERT INTO cliente (id_cliente, nombre, apellido_p, apellido_m, mesa_asignada) VALUES (seq_cliente.NEXTVAL, :nombre, :apellido_p, :apellido_m, :mesa_asignada)", conexion);
            comandoInsert.Parameters.Add(":nombre", txtnombre.Text);
            comandoInsert.Parameters.Add(":apellido_p", txtpaterno.Text);
            comandoInsert.Parameters.Add(":apellido_m", txtmaterno.Text);
            comandoInsert.Parameters.Add(":mesa_asignada", txtmesa.Text);

            int filasInsertadas = comandoInsert.ExecuteNonQuery();
            if (filasInsertadas > 0)
            {
                MessageBox.Show("Se ingreso el cliente con exito");
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el cliente");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                 conexion.Open();
            }

            // Insertar los datos de la reserva cancelada en una nueva tabla
            OracleCommand comandoInsert = new OracleCommand("INSERT INTO reservas_canceladas (nombre, apellido_p, apellido_m, mesa_asignada, fecha_cancelacion) VALUES (:nombre, :apellido_p, :apellido_m, :mesa_asignada, :fecha_cancelacion)", conexion);
            comandoInsert.Parameters.Add(":nombre", txtnombre.Text);
            comandoInsert.Parameters.Add(":apellido_p", txtpaterno.Text);
            comandoInsert.Parameters.Add(":apellido_m", txtmaterno.Text);
            comandoInsert.Parameters.Add(":mesa_asignada", txtmesa.Text);
            comandoInsert.Parameters.Add(":fecha_cancelacion", DateTime.Now); // Aquí se usa la fecha y hora actual como fecha de cancelación, puedes ajustarlo según tus necesidades

            int filasInsertadas = comandoInsert.ExecuteNonQuery();
            if (filasInsertadas > 0)
            {
                MessageBox.Show("Se guardó la reserva cancelada con éxito en la tabla de reservas canceladas");
            }
            else
            {
                MessageBox.Show("No se pudo guardar la reserva cancelada en la tabla de reservas canceladas");
            }

            // Eliminar los registros de la reserva cancelada de la tabla original
            OracleCommand comandoDelete = new OracleCommand("DELETE FROM cliente WHERE nombre = :nombre AND apellido_p = :apellido_p AND apellido_m = :apellido_m AND mesa_asignada = :mesa_asignada", conexion);
            comandoDelete.Parameters.Add(":nombre", txtnombre.Text);
            comandoDelete.Parameters.Add(":apellido_p", txtpaterno.Text);
            comandoDelete.Parameters.Add(":apellido_m", txtmaterno.Text);
            comandoDelete.Parameters.Add(":mesa_asignada", txtmesa.Text);

            int filasEliminadas = comandoDelete.ExecuteNonQuery();
            if (filasEliminadas > 0)
            {
                MessageBox.Show("Se eliminaron los registros de cliente con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar los registros de cliente");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comando = new OracleCommand("UPDATE cliente SET nombre=:nombre, apellido_p=:apellido_p, apellido_m=:apellido_m WHERE mesa_asignada=:mesa_asignada", conexion);
            comando.Parameters.Add(":nombre", txtnombre.Text);
            comando.Parameters.Add(":apellido_p", txtpaterno.Text);
            comando.Parameters.Add(":apellido_m", txtmaterno.Text);
            comando.Parameters.Add(":mesa_asignada", txtmesa.Text);

            int filasModificadas = comando.ExecuteNonQuery();

            if (filasModificadas > 0)
            {
                MessageBox.Show("Se modificaron los datos del cliente con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo modificar los datos del cliente");
            }
        }

        private void IngresoCliente_Load(object sender, EventArgs e)
        {


            // Crear un objeto DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();

           
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            // Crear un objeto OracleCommand para ejecutar la consulta
            OracleCommand comando = new OracleCommand("SELECT * FROM CLIENTE", conexion);

            // Crear un objeto OracleDataAdapter para llenar el objeto DataTable con los resultados de la consulta
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            adaptador.Fill(dt);

            // Enlazar el DataGridView al objeto DataTable
            dataGridView1.DataSource = dt;
        }
    }
    
}
