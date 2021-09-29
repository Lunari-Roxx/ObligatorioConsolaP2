using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
  public class Compra
    {
        private static int ultimoID = 1;
        private int ID { get; set; }
        public Actividad Actividad { get; set; }
        public DateTime FechaCompra { get; set; }
        public bool Estado { get; set; }
        public Cliente Cliente { get; set; }
        public int CantidadEntradas { get; set; }

        public Compra(Actividad actividad, DateTime fechaCompra, bool estado, Cliente cliente, int cantidadEntradas)
        {
            Actividad = actividad;
            FechaCompra = fechaCompra;
            Estado = estado;
            Cliente = cliente;
            CantidadEntradas = cantidadEntradas;
        }

        public double CalcularPrecioFinal()
        {
            return 0;
        }
    }
}
