using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-UVOMFLN\\SQLEXPRESS;Database=dkan;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario=@NombreUsuario AND Contrasena=@Contrasena";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        Login log = new Login();
                        log.Close();
                        seleccion_evento form = new seleccion_evento();
                        form.Show();
                        // Aquí puedes abrir un nuevo formulario o realizar alguna acción adicional
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
