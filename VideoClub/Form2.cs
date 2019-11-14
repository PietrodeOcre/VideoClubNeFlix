using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class Form2 : Form
    {
        private static bool us = false;
        public Form2()
        {
            InitializeComponent();
        }
        private static void login(bool us)
        {
            Form1.user = us;
        }
        private static SqlConnection connect()
        {
            return new SqlConnection("server=PIETRODEOCRE-PC\\SQLEXPRESS ; database=Ejercicio3 ; integrated security = true");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = connect();
            conexion.Open();
            string nombre = usuario.Text;
            string cadena = "SELECT usuario, passw FROM tabla_usuarios WHERE usuario='" + nombre + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            try
            {
                if (registro.Read())
                {
                    string user = registro["usuario"].ToString().Trim();
                    if (user.Equals(nombre))
                    {
                        if (passw.Text.Equals(registro["passw"].ToString().Trim()))
                        {
                            MessageBox.Show("Usuario identificado.");

                            us = true;
                        }
                        else
                        {
                            MessageBox.Show("Error en la contraseña.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Respete Mayúsculas y Minúsculas.");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
#pragma warning disable CS0168 // La variable 'fg' se ha declarado pero nunca se usa
            catch (SqlException fg)
#pragma warning restore CS0168 // La variable 'fg' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error de conexión.");
            }
            conexion.Close();

            if (us == true)
            {
                login(us);
                this.Owner.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes loguearte.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            this.Close();


        }


    }
}
