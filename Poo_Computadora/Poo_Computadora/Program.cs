using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(100, 0, true);
            Console.WriteLine("Desea enceder la pc? (s/n)");
            string r = Console.ReadLine().ToLower();
            if(r=="s")
            {
                computadora.Encender();
                Console.WriteLine("ingrese la cantidad de datos a añadir:");
                int datos = int.Parse(Console.ReadLine());
                computadora.AñadirDatos(datos);
                Console.WriteLine("Ingrese la cantidad de datos a eliminar");
                datos = int.Parse(Console.ReadLine());
                computadora.EliminarDato(datos);
                Console.ReadKey();
            }
            else
            {
                computadora.Apagar();
                Console.ReadKey();
            }    
        }
    }
}
