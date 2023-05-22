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
    public partial class IngresarEmpleado : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");

        public IngresarEmpleado()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();

            this.Hide();
            MenuAdmin menuadmin = new MenuAdmin();
            menuadmin.Show();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comandoId = new OracleCommand("SELECT MAX(id_empleado) FROM empleado", conexion);
            int ultimoId = Convert.ToInt32(comandoId.ExecuteScalar());

            
            int nuevoId = ultimoId + 1;

            OracleCommand comando = new OracleCommand("INSERT INTO empleado (id_empleado, nombre, direccion, telefono, correo, cargo, RESTAURANTE_ID_RESTARUANTE) VALUES (seq_empleados.NEXTVAL, :nombre, :direccion, :telefono, :correo, :cargo, 1)", conexion);
            comando.Parameters.Add(":nombre", txtnombre.Text);
            comando.Parameters.Add(":direccion", txtdireccion.Text);
            comando.Parameters.Add(":telefono", txttelefono.Text);
            comando.Parameters.Add(":correo", txtcorreo.Text);
            comando.Parameters.Add(":cargo", cbcargo.SelectedItem.ToString());

            int filasInsertadas = comando.ExecuteNonQuery();
            if (filasInsertadas > 0)
            {
                MessageBox.Show("Empleado agregado exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el empleado");
            }
        }

        private void IngresarEmpleado_Load(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comando = new OracleCommand("SELECT * FROM EMPLEADO", conexion);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
