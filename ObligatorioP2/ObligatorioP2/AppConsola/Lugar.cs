using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
   public abstract class Lugar
    {
        protected static int ultimoID = 1;
        protected int ID { get; set; }
        public string Nombre { get; set; }
        public double Dimensiones { get; set; }

        
    }
}
