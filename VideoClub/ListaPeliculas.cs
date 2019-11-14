using System;

namespace VideoClub
{
    class ListaPeliculas
    {
        private static int identificador = 0;
        private int id;
        private string nombre;
        private string director;
        private int estreno;
        private string genero;
        private string sinopsis;
        private int cantidad;
        private double precio;

        public ListaPeliculas(int id, string nombre, string director, int estreno, string genero, string sinopsis, int cantidad, double precio)
        {

            this.Id = Identificador;
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.Director = director ?? throw new ArgumentNullException(nameof(director));
            this.Estreno = estreno;
            this.Genero = genero ?? throw new ArgumentNullException(nameof(genero));
            this.Sinopsis = sinopsis ?? throw new ArgumentNullException(nameof(sinopsis));
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public static int Identificador { get => identificador; set => identificador = value++; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Director { get => director; set => director = value; }
        public int Estreno { get => estreno; set => estreno = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {

            return string.Format("{0}:{1}", Id, Nombre);
        }




    }



}
