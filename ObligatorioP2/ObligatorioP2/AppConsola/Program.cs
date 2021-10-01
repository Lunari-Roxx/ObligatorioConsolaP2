using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema s = new Sistema();

            foreach(Lugar lugar in s.GetLugares())
            {
                Console.WriteLine(lugar.Nombre);
            }

            Console.WriteLine("****");
            Console.WriteLine("****");
            foreach(Cliente cli in s.GetClientes())
            {
                Console.WriteLine(cli.ToString());
            }
            Console.ReadKey();
        }
    }
}
