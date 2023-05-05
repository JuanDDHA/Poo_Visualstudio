using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_CasaComercial
{
    class CasaComercial
    {
        string nombre;
        string email;
        int totalvehiculo;
        //se crea una lista de objetos de la clase vehiculo en la clase comercial
        List<Vehiculo> vehiculos;
        
        public CasaComercial(string nombre, string email, int totalvehiculo, List<Vehiculo> vehiculos)
        {
            this.nombre = nombre;
            this.email = email;
            this.totalvehiculo = totalvehiculo;
            this.vehiculos = vehiculos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Totalvehiculo { get => totalvehiculo; set => totalvehiculo = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }
        //Añadir metodos
        public void AnadirVehiculo(Vehiculo v)
        {
            try
            {
                //añadimos el vehiculo a la lista
                this.vehiculos.Add(v);
                //aumentamos el total de vehiculos
                this.totalvehiculo += 1;
                Console.WriteLine("Se a añadido un vehiculo al inventario...");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error.... no se a podido añadir el vehiculo: " + e.Message);
                Console.ReadLine();
                throw;
            }
        }
        public void MostrarVehiculo()
        {
            try
            {
                foreach(var v in this.vehiculos)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error... al mostrar los vehiculos "+ e.Message);
                Console.ReadLine();
                throw;
            }
        }
        public void VaciarVehiculo()
        {
            Console.WriteLine("Esta seguro que sea vaciar la lista vehiculos? (s/n): ");
            string r = Console.ReadLine().ToLower();
            if(r =="s")
            {
                vehiculos = new List<Vehiculo>();
                this.totalvehiculo = 0;
                Console.WriteLine("Se ha vaciado la lista vihiculos...");
            }
            else
            {
                Console.WriteLine("No se ha vaciado la lista vehiculos...");
                Console.ReadLine();
            }
        }
        public void EliminarVehiculo(Vehiculo v)
        {
            vehiculos.Remove(v);
            this.totalvehiculo -= 1;
            Console.WriteLine("Se ha eliminado el vehiculo correctamente");
            Console.ReadLine();
        }

    }
}
