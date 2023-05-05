using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo4_HerenciaVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo(1, "halux", "cem", 5000, 40000, 2022);
            Console.WriteLine("Vehiculo: " + v);
            Console.WriteLine("\n\n");
            Auto auto = new Auto(1, "asus", "toto", 10000, 40000, 2020, true);
            Console.WriteLine("Auto: " + auto);
            Console.WriteLine("\n\n");
            Moto moto = new Moto(1, "vento", "suzuki", 3000, 48000, 2022, true);
            Console.WriteLine("Moto: " + moto);
            Console.ReadKey();
            
        }
    }
}
