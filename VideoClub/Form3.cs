using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static SqlConnection connect()
        {
            return new SqlConnection("server=localhost\\SQLEXPRESS ; database=Ejercicio3 ; integrated security = true");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = connect();
            string query = "INSERT INTO tabla_peliculas (nombre,director,estreno,genero,sinopsis,cantidad,precio) VALUES (@nombre,@director,@estreno,@genero,@sinopsis,@cantidad,@precio)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            //comando.Parameters.AddWithValue("@id", textBox1.Text); Cagada Josele, por pensar que no era autoincrem
            comando.Parameters.AddWithValue("@nombre", textBox2.Text);
            comando.Parameters.AddWithValue("@director", textBox3.Text);
            comando.Parameters.AddWithValue("@estreno", textBox4.Text);
            comando.Parameters.AddWithValue("@genero", textBox5.Text);
            comando.Parameters.AddWithValue("@precio", textBox6.Text);
            comando.Parameters.AddWithValue("@cantidad", textBox7.Text);
            comando.Parameters.AddWithValue("@sinopsis", textBox8.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha dado de alta una película.");

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
