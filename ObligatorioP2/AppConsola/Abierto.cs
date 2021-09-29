using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
   public class Abierto : Lugar
    {
        public static double precio_butaca;

        public Abierto(string nombre, double dimensiones)
        {
            Nombre = nombre;
            Dimensiones = dimensiones;
        }
    }
}
