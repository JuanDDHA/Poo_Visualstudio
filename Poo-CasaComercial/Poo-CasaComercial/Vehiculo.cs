using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_CasaComercial
{
    class Vehiculo
    {
        int id;
        string marca;
        string modelo;
        int km;
        decimal precio;
        int año;

        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int año)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
            this.año = año;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Año { get => año; set => año = value; }
        public override string ToString()
        {
            return "Modelo: " + modelo + "\nMarca: " + marca +"\nkilometraje:" + km + "\nAño: " + año + "\nPrecio: " + precio + "\n";
        }
    }
}
