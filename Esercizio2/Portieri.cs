using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Portieri:Calciatori
    {
        //I Portieri sono calciatori e hanno numero maglia = 1(di default) e il numero di goal subiti.
        public int NgolSubiti;

        public Portieri() { }
        public Portieri(string n, string c, int e, int ng)
            :base(n, c, e, 0, 1)
        {
          NgolSubiti = ng;
        }
        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\nNumero gol subiti: {NgolSubiti}");
        }
        public List<Portieri> ListaPortieriItalia()
        {
            List<Portieri> listaPortieriItalia = new List<Portieri>();
            listaPortieriItalia.Add(new Portieri("Mauro", "Rossi", 20, 5));
            listaPortieriItalia.Add(new Portieri("Tommaso", "Bianchi", 23, 10));
            listaPortieriItalia.Add(new Portieri("Alessandro", "Rossi", 28, 2));
                return listaPortieriItalia; 
        }
        //public List ListaPortieriInghilterra()
        //{
        //    List<Portieri> listaPortieriInghilterra = new List<Portieri>();
        //    parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        //    parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        //    parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });

        //    return listaPortieriItalia;
        //}
    }
}
