using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_CasaComercial
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaComercial casaComercial = new CasaComercial("autolote juan", "contactanos@gmail.com", 0, new List<Vehiculo>());
            casaComercial.AnadirVehiculo(new Vehiculo(1, "toyota", "servento", 10000, 30000, 2019));
            casaComercial.MostrarVehiculo();
            Console.ReadKey();
        }
        static void Pedir(string m, ref int x)
        {
            Console.WriteLine(m);
            x = int.Parse(Console.ReadLine());
        }
    }
}
