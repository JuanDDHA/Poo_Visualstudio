using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Foto
{
    class Program
    {
        static void Main(string[] args)
        {
            //añadir fotos
            Foto foto1 = new Foto(1, 10, 2023, "me gusta");
            Foto foto2 = new Foto(2, 10, 2023, "Regular");

            //crear album y añadir fotos
            Album album1 = new Album(1, "para el face", 2023,1, new List<Foto> { foto1, foto2 });
            Console.WriteLine("\n");

            //Mostrar fotos del album
            album1.MostrarFoto();
            Console.WriteLine("\n\n");
            Foto foto3 = new Foto(4, 1.8,2022,"que mal");
            album1.AñadirFoto(foto3);
            album1.MostrarFoto();
            Console.WriteLine("\n");
            // Obtener el tamaño del álbum en GB
            double tamanoGB = album1.TamañoAlbum();
            Console.WriteLine(tamanoGB);
            Console.ReadKey();
        }
    }
}
