using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    public class Actividad
    {
        public static double precioBase;
        private static int ultimoID = 1;
        private int ID { get; set; }
        public string Nombre { get; set; }
        public Lugar Lugar { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadMeGusta { get; set; }
        public Calificacion EdadMinima { get; set; }
        public Categoria Categoria { get; set; }

        public enum Calificacion
        {
            C13,
            C16,
            C18,
            ALL
        }

        public Actividad(string nombre, Lugar lugar, DateTime fecha, int cantidadMeGusta, Calificacion edadMinima, Categoria categoria)
        {
            Nombre = nombre;
            Lugar = lugar;
            Fecha = fecha;
            CantidadMeGusta = cantidadMeGusta;
            EdadMinima = edadMinima;
            Categoria = categoria;
            ID = ultimoID;
            ultimoID++;
        }

        public double CalcularPrecio()
        {
            return 0;
        }
    }

}
