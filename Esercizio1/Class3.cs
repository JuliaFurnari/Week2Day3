using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Bicicletta : Veicolo
    {
        public bool Elettrica;
        

        public Bicicletta()
        {
        }
        public Bicicletta(string b, string m, int c, bool bo)
            : base(b, m, c)
        {
            Elettrica = bo;
            
        }
        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.Write(" " + " Elettrica: " + Elettrica);
        }
        public override void GetInfo()
        {
            Console.WriteLine(Brand + " " + Modello + " " + " " + Codice);
        }
    }
}
