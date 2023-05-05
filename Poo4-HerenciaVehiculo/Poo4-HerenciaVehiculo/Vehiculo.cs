using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo4_HerenciaVehiculo
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
            return "Modelo: " + modelo + "\nMarca: " + marca + "\nPrecio: " + precio + "\nAño: " + año + "\n";
        }
        public virtual decimal CalPrecio()
        {
            return precio;
        }
        
        
    }
    class Auto : Vehiculo
    {
        bool airbag;
        public Auto(int id, string marca, string modelo, int km, decimal precio, int año, bool airbag)
            : base(id, marca, modelo, km, precio, año)
        {
            this.airbag = airbag;
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override decimal CalPrecio()
        {
            if (Airbag)
            {
                return base.CalPrecio() + 200;
            }
            else
            {
                return base.CalPrecio();
            }
        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + "\nMarca: " + Marca + "\nPrecio: " + CalPrecio() + "\nAño: " + Año + "\n";
        }
    }
    class Moto : Vehiculo
    {
        bool sidecar;
        public Moto(int id, string marca, string modelo, int km, decimal precio, int año, bool sidecar)
            : base(id, marca, modelo, km, precio, año)
        {
            this.sidecar = sidecar;
        }

        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal CalPrecio()
        {
            if (sidecar)
            {
                return base.CalPrecio() + 50;
            }
            else
            {
                return base.CalPrecio();
            }
        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + "\nMarca: " + Marca + "\nPrecio: " + CalPrecio() + "\nAño: " + Año + "\n";
        }
    }

}
