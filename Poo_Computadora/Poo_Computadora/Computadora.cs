using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Computadora
{
    class Computadora
    {
        int capdisco;
        int espciodisponible;
        bool on = false;

        public Computadora(int capdisco, int espciodisponible, bool on)
        {
            this.capdisco = capdisco;
            this.espciodisponible = espciodisponible;
            this.on = on;
        }

        public int Capdisco { get => capdisco; set => capdisco = value; }
        public int Espciodisponible { get => espciodisponible; set => espciodisponible = value; }
        public bool On { get => on; set => on = value; }
        public void AñadirDatos(int datos)
        {
            if(on)
            {
                if(datos>espciodisponible)
                {
                    espciodisponible = 0;
                }
                else
                {
                    espciodisponible -= datos;
                }
            }
            else
            {
                Console.WriteLine("lacomputadora esta apagada");
            }
        }
        public void EliminarDato(int datos)
        {
            if(on)
            {
                if(datos<espciodisponible)
                {
                    espciodisponible += datos;
                }
                else
                {
                    espciodisponible = capdisco;
                }
            }
        }
        public void Encender()
        {
            on = true;
            if(on)
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("no se ha podido enceder...esta conectada la unidad a la fuente de poder?...intente de nuevo ");
            }
            
        }
        public void Apagar()
        {
            Console.WriteLine("apagando la unidad... espere unos instantes...");
        }

    }
}
