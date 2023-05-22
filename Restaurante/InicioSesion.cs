using Intercom.Core;
using MySql.Data.MySqlClient;
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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL ; PASSWORD = admin ; USER ID = Admin");
        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            OracleCommand comando = new OracleCommand("SELECT * FROM usuario WHERE NOMBRE_USUARIO = :NOMBRE_USUARIO AND CONTRASENA = :CONTRASENA", conexion);

            comando.Parameters.Add("nombre_usuario", txtUsuario.Text);
            comando.Parameters.Add("contrasena", TxtContrasena.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                string rol = lector.GetString(3);

                switch (rol)
                {
                    case "admin":
                        MenuAdmin menuAdmin = new MenuAdmin();
                        menuAdmin.Show();
                        this.Hide();
                        break;
                    case "recepcion":
                        MenuRecepcion menuRecepcion = new MenuRecepcion();
                        menuRecepcion.Show();
                        this.Hide();
                        break;
                    case "cocina":
                        MenuCocina menuCocina = new MenuCocina();
                        menuCocina.Show();
                        this.Hide();
                        break;
                    case "finanza":
                        MenuFinanza menuFinanza = new MenuFinanza();
                        menuFinanza.Show();
                        this.Hide();
                        break;
                    case "bodeguero":
                        MenuBodeguero menuBodeguero = new MenuBodeguero();
                        menuBodeguero.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
    }

}
