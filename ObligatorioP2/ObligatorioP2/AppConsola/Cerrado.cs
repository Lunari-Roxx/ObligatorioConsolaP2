using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    public class Cerrado : Lugar
    {
    public bool AccesibilidadTotal { get; set; }
    public double ValorMantenimiento { get; set; }

        public Cerrado(bool accesibilidadTotal, double valorMantenimiento, string nombre , double dimensiones)
        {
            ID = ultimoID;
            ultimoID++;
            AccesibilidadTotal = accesibilidadTotal;
            ValorMantenimiento = valorMantenimiento;
            Nombre = nombre;
            Dimensiones = dimensiones;
        }
    }
}
