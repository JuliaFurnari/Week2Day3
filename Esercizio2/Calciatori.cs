using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Calciatori:Atleti
    {
        public RoleEnum Ruolo;
        public int NMaglia;

        public Calciatori() { }
        public Calciatori(string n, string c, int e, RoleEnum r, int nm)
            :base(n, c, e)
        {
            Ruolo = r;
            NMaglia = nm;
        }

        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write($"\nRuolo: {Ruolo}" + $"\nNumero Maglia: {NMaglia}");
        }
        public enum RoleEnum
        {
            Portiere,
            Difensore,
            Centrocampista,
            Attaccante

        }
    }
}
