using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Automobile : Veicolo
    {
        public string Targa;
        public string Carburante;

        public Automobile(){
                    }
        public Automobile(string b, string m, int c, string t, string carb)
            :base(b, m, c) 
        {
            Targa = t;
            Carburante = carb;
        }
        public override void PrintInfo()
        {
           
            base.PrintInfo();
            Console.Write(" " + Targa + " " + Carburante);
        }
        public override void GetInfo()
        {
            Console.WriteLine(Brand + " " + Modello + " " + " " + Codice);
        }
    }
}
