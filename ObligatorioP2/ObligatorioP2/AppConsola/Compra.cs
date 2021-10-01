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

        public double PrecioTotal { get; set; }

        public Compra(Actividad actividad, DateTime fechaCompra,  Cliente cliente, int cantidadEntradas)
        {
            ID = ultimoID;
            ultimoID++;
            Actividad = actividad;
            FechaCompra = fechaCompra;
            Estado = true;
            Cliente = cliente;
            CantidadEntradas = cantidadEntradas;
            PrecioTotal = CalcularPrecioFinal();
        }

        public double CalcularPrecioFinal()
        {
            return 0;
        }
    }
}
