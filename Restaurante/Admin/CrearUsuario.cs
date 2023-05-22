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
    public partial class CrearUsuario : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comandoVerificar = new OracleCommand("SELECT COUNT(*) FROM usuario WHERE nombre_usuario = :nombre_usuario", conexion);
            comandoVerificar.Parameters.Add(":nombre_usuario", txtusuarionuevo.Text);
            int cantidadUsuarios = Convert.ToInt32(comandoVerificar.ExecuteScalar());

            if (cantidadUsuarios == 0)
            {
                MessageBox.Show("El usuario no existe en la base de datos");
            }
            else
            {
                // Modificar la contraseña y el rol del usuario
                OracleCommand comandoModificar = new OracleCommand("UPDATE usuario SET contrasena = :contrasena, rol = :rol WHERE nombre_usuario = :nombre_usuario", conexion);
                comandoModificar.Parameters.Add(":contrasena", txtcontrasenanueva.Text);
                comandoModificar.Parameters.Add(":rol", cbroles.SelectedItem.ToString());
                comandoModificar.Parameters.Add(":nombre_usuario", txtusuarionuevo.Text);

                int filasModificadas = comandoModificar.ExecuteNonQuery();
                if (filasModificadas > 0)
                {
                    MessageBox.Show("Usuario modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario");
                }
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comandoId = new OracleCommand("SELECT MAX(id_usuario) FROM usuario", conexion);
            int ultimoId = Convert.ToInt32(comandoId.ExecuteScalar());


            int nuevoId = ultimoId + 1;

            OracleCommand comando = new OracleCommand("INSERT INTO usuario (nombre_usuario, contrasena, rol) VALUES (:nombre_usuario, :contrasena, :rol)", conexion);
            comando.Parameters.Add(":nombre_usuario", txtusuarionuevo.Text);
            comando.Parameters.Add(":contrasena", txtcontrasenanueva.Text);
            comando.Parameters.Add(":rol", cbroles.SelectedItem.ToString());

            int filasInsertadas = comando.ExecuteNonQuery();
            if (filasInsertadas > 0)
            {
                MessageBox.Show("Usuario agregado exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el usuario");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comando = new OracleCommand("DELETE FROM usuario WHERE nombre_usuario = :nombre_usuario AND contrasena = :contrasena AND rol = :rol AND EMPLEADO_ID_EMPLEADO = :id_empleado", conexion);
            comando.Parameters.Add(":nombre_usuario", txtusuarionuevo.Text);
            comando.Parameters.Add(":contrasena", txtcontrasenanueva.Text);
            comando.Parameters.Add(":rol", cbroles.SelectedItem.ToString());

            int filasEliminadas = comando.ExecuteNonQuery();
            if (filasEliminadas > 0)
            {
                MessageBox.Show("Usuario eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario");
            }
        }


        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO", conexion);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            
            this.Close();

            this.Hide();
            MenuAdmin menuadmin = new MenuAdmin();  
            menuadmin.Show();  
        }
    }
}
