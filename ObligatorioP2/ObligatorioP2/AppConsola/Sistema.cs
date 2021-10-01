using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    public class Sistema
    {
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Compra> Compras = new List<Compra>();
        public List<Actividad> Actividades = new List<Actividad>();
        public List<Lugar> Lugares = new List<Lugar>();
        public List<Categoria> Categorias = new List<Categoria>();
        public double AforoMaximo { get; set; }

        public Sistema()
        {
            Precarga();
        }

        public List<Lugar> GetLugares()
        {
            return Lugares;
        }

        public List<Cliente> GetClientes()
        {
            return Clientes;
        }

        public Cliente AltaLugarCliente(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            Cliente cliente = null;
            if (nombre != "" && apellido != "" && email != "") //validar fecha nacimiento
            {
                cliente = new Cliente(nombre, apellido, email, fechaNacimiento);
                Clientes.Add(cliente);
            }
            return cliente;
        }

        public Abierto AltaLugarAbierto(string Nombre, double Dimensiones)
        {
            Abierto lugar = new Abierto(Nombre, Dimensiones);
            Lugares.Add(lugar);
            return lugar;
        }

        public Cerrado AltaLugarCerrado(string nombre, double dimensiones, bool accesibilidadTotal, double valorMantenimiento)
        {
            Cerrado lugar = null;
            if (nombre != "" && dimensiones > 0 && valorMantenimiento > 0) // validar accesibilidad
            {
                lugar = new Cerrado(accesibilidadTotal, valorMantenimiento, nombre, dimensiones);
                Lugares.Add(lugar);
            }
            return lugar;
        }


        public Categoria AltaCategoria(string nombre, string descripcion)
        {
            Categoria categoria = null;
            if (nombre != "" && descripcion != "")
            {
                categoria = new Categoria(nombre, descripcion);
                Categorias.Add(categoria);

            }
            return categoria;
        }

        public Actividad AltaActividad(string nombre, Actividad.Calificacion edadMinima, Lugar lugar, DateTime fecha,
            int cantidadMeGusta, Categoria categoria)
        {
            Actividad actividad = null;
            if (nombre != "" && edadMinima > 0 && cantidadMeGusta > -1) // verificar fecha, lugar, categoria

            {
                actividad = new Actividad(nombre, lugar, fecha, cantidadMeGusta, edadMinima , categoria);
            }
            
                return actividad;
        }

            public void Precarga()
            {
                Abierto a1 = AltaLugarAbierto("Plaza Liber Seregni", 10);
                Abierto a2 = AltaLugarAbierto("jardin botanico", 100);
                Abierto a3 = AltaLugarAbierto("jardin japones", 300);
                Abierto a4 = AltaLugarAbierto("estadio centenario", 500);

                Cerrado c1 = AltaLugarCerrado("Museo Blanes", 100, false, 700);
                Cerrado c2 = AltaLugarCerrado("Palacio Legislativo", 230, true, 1000);
                Cerrado c3 = AltaLugarCerrado("Palacio Peñarol", 50, true, 300);
                Cerrado c4 = AltaLugarCerrado("cine ejido", 30, false, 600);

                Cliente cli1 = AltaLugarCliente("juan", "perez", "juanpe@gmail.com", DateTime.Parse("2021-10-01"));
                Cliente cli2 = AltaLugarCliente("sofia", "ares", "ares@gmail.com", DateTime.Parse("1999-11-13"));
                Cliente cli3 = AltaLugarCliente("matias", "gonzales", "gonzaa@gmail.com", DateTime.Parse("1999-11-13"));

                Categoria cat1 = AltaCategoria("teatro", "obra teatral");
                Categoria cat2 = AltaCategoria("cine", "film cinematografico");
                Categoria cat3 = AltaCategoria("concierto", "espectáculo con banda musical");


                Actividad act1 = AltaActividad("black widow",Actividad.Calificacion.P,a4,DateTime.Parse("2021-12-13"),600,cat2);
                Actividad act2 = AltaActividad("artic monkeys world tour",Actividad.Calificacion.C13,c4,DateTime.Parse("2021-11-13"),600,cat2);
               
                
            }

        }



    }
