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
    public partial class Form1 : Form
    {
        public Form1()
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

            OracleCommand comando = new OracleCommand("select * from usuarios where nombre_usuario = :nombre_usuario and contrasena = :contrasena", conexion);

            comando.Parameters.Add(":usuario", txtUsuario.Text);
            comando.Parameters.Add("contrasena", TxtContrasena.Text);

            OracleDataReader lector = comando.ExecuteReader();


            if (lector.Read())
            {
                string rol = lector.GetString(2); 

                if (rol == "admin")
                {
                    
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.Show();
                    this.Hide(); 
                }
                else
                {

                    InicioSesion inicioSesion = new InicioSesion();
                    inicioSesion.Show();
                    this.Hide(); 
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
