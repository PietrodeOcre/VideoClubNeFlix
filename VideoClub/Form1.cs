using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoClub
{


    public partial class Form1 : Form
    {

        public static bool user;
        public Form1()
        {
            InitializeComponent();
            LlenarListBox();

        }
        private string connect()
        {
            return "server=PIETRODEOCRE-PC\\SQLEXPRESS ; database=Ejercicio3 ; integrated security = true";
        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show(this);
            form.Close();
            this.Hide();
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = false;
            this.Hide();
            this.Show();
            MessageBox.Show("El usuario ya no está logueado.");
        }

        private void LlenarListBox()
        {
            SqlConnection conexion = new SqlConnection(connect());
            conexion.Open();
            string cadena = "SELECT nombre FROM tabla_peliculas";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                this.listBox1.Items.Add(registro["nombre"].ToString().Trim());
            }
            conexion.Close();
        }

        private void Loguer(object sender, EventArgs e)
        {
            if (user == true)
            {
                logueado.Text = "Usuario conectado";
            }
            else
            {
                logueado.Text = "Usuario desconectado";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connect());
            conexion.Open();
            string cadena = "SELECT * FROM tabla_peliculas WHERE nombre = '" + listBox1.SelectedItem + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            
            registro.Read();
            id.Text = registro["id"].ToString().Trim();
            titulo.Text = registro["nombre"].ToString().Trim();
            director.Text = registro["director"].ToString().Trim();
            estreno.Text = registro["estreno"].ToString().Trim();
            genero.Text = registro["genero"].ToString().Trim();
            sinopsis.Text = registro["sinopsis"].ToString().Trim();
            cant.Text = registro["cantidad"].ToString().Trim();
            precio.Text = registro["precio"].ToString().Trim();
            conexion.Close();
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int canti = int.Parse(cant.Text.ToString());
            canti = canti - 1;
            SqlConnection conexion = new SqlConnection(connect());
            conexion.Open();
            string cadena = null;
            cadena = "UPDATE  [Ejercicio3].[dbo].[tabla_peliculas] SET cantidad=" + canti.ToString() + " where nombre='" + listBox1.SelectedItem + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha realizado un alquiler: " + listBox1.SelectedItem);
            conexion.Close();

            conexion.Open();
            cadena = null;
            cadena = "SELECT cantidad FROM tabla_peliculas WHERE nombre = '" + listBox1.SelectedItem + "'";
            comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            cant.Text = registro["cantidad"].ToString().Trim();
            conexion.Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre = I;
        }
    }
}
