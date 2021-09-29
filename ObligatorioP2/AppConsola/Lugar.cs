using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
   public abstract class Lugar
    {
        private static int ultimoID = 1;
        private int ID { get; set; }
        public string Nombre { get; set; }
        public double Dimensiones { get; set; }

        
    }
}
