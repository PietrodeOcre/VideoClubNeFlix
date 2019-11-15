using Microsoft.VisualBasic;
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
            //En el inicio del programa cargamos el listBox con los nombres d elas peliculas
            LlenarListBox();

        }

        /*
         * Este metodo crea un String para pasarle al conector SQL
         */
        private string connect()
        {
            return "server=PIETRODEOCRE-PC\\SQLEXPRESS ; database=Ejercicio3 ; integrated security = true";
        }

        /*
         * Funcionalidad del boton de cerrar el programa.
         */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show(this);
            this.Hide();
        }

        /*
         * Funcionalidad del boton de desconectar el usuario.
         */
        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = false;
            this.Hide();
            this.Show();
            MessageBox.Show("El usuario ya no está logueado.");
        }

        /*
         * Metodo que llena el listBox al abrir el programa.
         */
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

        /*
         * Metodo para comprobar si estamos o no conectados
         * Lo muestra por la interface mediante un label
         */
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

        /*
         * Funcionalidad del listBox mediante la cual si pulsamos en 
         * un elemento de la lista se selecciona y carga en los demas 
         * cuadros de texto los datos de esa pelicula concretamente.
         */
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

        /*
         * Funcionalidad del Alquilar de de restar uno a la cantidad
         * de unidades disponibles de dicha pelicula.
         * Ademas tambien actualiza el numero en el cuadro de texto correspondiente
         */
        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int canti = 0;
            try
            {
                canti = int.Parse(cant.Text.ToString());
            }
            catch (Exception)
            {
                canti = 0;
                
            }

            canti = canti - 1;

            if (canti == -1)
            {
                MessageBox.Show("Debes seleccionar una película.");
            }
            else if (canti > 0)
            {
                if (user == true)
                {
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
                else
                {
                    MessageBox.Show("Debes estar logueado para poder acceder a esta funcionalidad");
                }
            }
            else
            {
                MessageBox.Show("No quedan copias disponibles de la pelicula " + listBox1.SelectedItem);
            }

        }

        /*
         * Funcionalidad del Buscar de mostrar un una ventana de busqueda
         * que comprueba si el nombre de la pelicula introducido esta en la lista
         * con lo que nos la selecciona y nos muestra sus datos si la encuentra
         * de lo contrario indica que no existe.
         */
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese Nombre de la película:", Title: "Busqueda", "Nombre", 100, 0);

            //listBox1.FindString(nombre);

            SqlConnection conexion = new SqlConnection(connect());
            conexion.Open();

            string cadena = "SELECT * FROM tabla_peliculas WHERE nombre = '" + listBox1.GetItemText(nombre) + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            int num = int.Parse(listBox1.GetItemText(listBox1.FindString(nombre)));
            if (num > 0)
            {
                registro.Read();
                id.Text = registro["id"].ToString().Trim();
                titulo.Text = registro["nombre"].ToString().Trim();
                director.Text = registro["director"].ToString().Trim();
                estreno.Text = registro["estreno"].ToString().Trim();
                genero.Text = registro["genero"].ToString().Trim();
                sinopsis.Text = registro["sinopsis"].ToString().Trim();
                cant.Text = registro["cantidad"].ToString().Trim();
                precio.Text = registro["precio"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("El nombre: " + nombre + " no coincide con ninguna película");
            }
            listBox1.SelectedItem = nombre;
            conexion.Close();
 
        }

        /*
         * Funcionalidad del Devolver de sumar uno a la cantidad
         * de unidades disponibles de dicha pelicula.
         * Ademas tambien actualiza el numero en el cuadro de texto correspondiente
         */
        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int canti = 0;
            try
            {
                canti = int.Parse(cant.Text.ToString());
            }
            catch (Exception)
            {
                canti = 0;

            }

            canti = canti + 1;

            if (canti == -1)
            {
                MessageBox.Show("Debes seleccionar una película.");
            }
            else if (canti >= 0 || canti <= 5)//Este if puede usarse para comparar con la cantidad maxima que puede haber
            {
                if (user == true)
                {
                    SqlConnection conexion = new SqlConnection(connect());
                    conexion.Open();
                    string cadena = null;
                    cadena = "UPDATE  [Ejercicio3].[dbo].[tabla_peliculas] SET cantidad=" + canti.ToString() + " where nombre='" + listBox1.SelectedItem + "'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha realizado una devolución: " + listBox1.SelectedItem);
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
                else
                {
                    MessageBox.Show("Debes estar logueado para poder acceder a esta funcionalidad");
                }
            }
            else
            {
                /*
                 * Aqui pondremos el mensaje que el sistema da si llegamos al numero maximo
                 * de copias que teniamos en un principio, otra opcion es que pontamos un tope fijo 
                 * para cada pelicula, es decir, que siempre tengamos maximo 5 copias de cada pelicula
                 * con lo cual el tope maximo siempre sera de 5 es una opcion para no crear otra tabla
                 * 
                 * YA se ha incorporado esta opción, solo queda poner el interface bonito
                 */
                MessageBox.Show("Número de copias del producto es 5 esa pelicula no pertenece a este videoclub");
            }

        }
    }
}
