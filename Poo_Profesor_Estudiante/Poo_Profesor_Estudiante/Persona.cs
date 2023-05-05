using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Profesor_Estudiante
{
    class Persona
    {
        string nom;

        public Persona(string nom)
        {
            this.nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
        public override string ToString()
        {
            return "Nombre: " + nom + "\n";
        }

    }
    class Estudiante:Persona
    {
        public Estudiante(string nom) :base(nom)
        {

        }
        public void Estudiar()
        {
            Console.WriteLine("El estudiante esta al dia con la clase");
        }
    }
    class Profesor:Persona
    {
        public Profesor(string nom):base(nom)
        {

        }
        public void Explicar()
        {
            Console.WriteLine("El profesor esta explicando la clase");
        }
    }
}
