using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
   public class Cliente
    {

        private static int ultimoID = 1;
        private static int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"Id: {ID}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Fecha: {FechaNacimiento}";
        }

        public Cliente(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            ID = ultimoID;
            ultimoID++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            
        }
    }
}
