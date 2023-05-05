using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Foto
{
    class Foto
    {
        int idf;
        double sizemb;
        int fechacr;
        string coment;

        public Foto(int idf, double sizemb, int fechacr, string coment)
        {
            this.idf = idf;
            this.sizemb = sizemb;
            this.fechacr = fechacr;
            this.coment = coment;
        }

        public int Idf { get => idf; set => idf = value; }
        public double Sizemb { get => sizemb; set => sizemb = value; }
        public int Fechacr { get => fechacr; set => fechacr = value; }
        public string Coment { get => coment; set => coment = value; }
        public override string ToString()
        {
            return "ID Foto: " + idf + "\nTamaño Foto: " + sizemb +"mb"+ "\nFecha creacion foto: Enero/" + fechacr + "\nComentarios de la foto: " + coment + "\n";
        }
    }
}
