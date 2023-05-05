using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Foto
{
    class Album
    {
        int id;
        string nom;
        int fecha;
        int lisfoto;
        List<Foto> fotos;

        public Album(int id, string nom, int fecha, int lisfoto, List<Foto> fotos)
        {
            this.id = id;
            this.nom = nom;
            this.fecha = fecha;
            this.lisfoto = lisfoto;
            this.fotos = fotos;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public int Lisfoto { get => lisfoto; set => lisfoto = value; }
        internal List<Foto> Fotos { get => fotos; set => fotos = value; }
        public void AñadirFoto(Foto f)
        {
            try
            {
                this.fotos.Add(f);
                this.lisfoto += 1;
                Console.WriteLine("Se ha añadido una foto...");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error.... no se apodido guardar correctamente la foto..." + e.Message);
                Console.ReadLine();
                throw;
            }
        }
        public void MostrarFoto()
        {
            try
            {
                foreach(var f in this.fotos)
                {
                    Console.WriteLine(f.ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error...No se puede mostrar el formato de la foto" + e.Message);
                Console.ReadLine();
                throw;
            }
        }
        public void VaciarAlbum()
        {
            Console.WriteLine("Esta seguro que sea vaciar la lista de fotos? (s/n): ");
            string r = Console.ReadLine().ToLower();
            if (r == "s")
            {
                fotos = new List<Foto>();
                this.lisfoto = 0;
                Console.WriteLine("Se ha vaciado la lista fotos...");
            }
            else
            {
                Console.WriteLine("No se ha vaciado la lista fotos...");
                Console.ReadLine();
            }
        }
        public void EliminarVehiculo(Foto f)
        {
            fotos.Remove(f);
            this.lisfoto -= 1;
            Console.WriteLine("Se ha eliminado el vehiculo correctamente");
            Console.ReadLine();
        }
        public double TamañoAlbum()
        {
            double totalsizemb = 0;
            foreach(Foto f in Fotos)
            {
                totalsizemb += f.Sizemb;
            }
            return totalsizemb / 1024;
        }

    }
}
