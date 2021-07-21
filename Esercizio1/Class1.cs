using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    abstract class Veicolo 
    {
        public string Brand;
        public string Modello;
        public int Codice;

        public Veicolo() { }
        public Veicolo(string b, string m, int c)
        {
            Brand = b;
            Modello = m;
            Codice = c;
        }
        public virtual void PrintInfo()
        {
            Console.Write(Brand + " " + Modello + " " + Codice);
        }




        //Puoi rendere questa classe astratta e cosi non
        //puoi utilizzarla direttamente ma
        //solo le sottoclassi
        public void GetBrand()
        {
            Console.WriteLine(Brand);
        }

        //Questo metodo deve essere implementato dalle classi derivate
        public abstract void GetInfo() ;
    }
}
