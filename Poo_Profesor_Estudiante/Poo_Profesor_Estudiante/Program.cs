using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Profesor_Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            Profesor per1 = new Profesor("juan");
            personas[0] = per1;
            Estudiante per2 = new Estudiante("sara");
            personas[1] = per2;
            Estudiante per3 = new Estudiante("Carlos");
            personas[2] = per3;

            Console.WriteLine("\tImpresion");
            Console.WriteLine(per1.ToString());
            per1.Explicar();
            Console.WriteLine(per2.ToString());
            per2.Estudiar();
            Console.WriteLine(per3.ToString());
            per3.Estudiar();

            Console.ReadKey();
        }
    }
}
