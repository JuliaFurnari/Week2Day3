using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Atleti
    {
        public string Nome;
        public string Cognome;
        public int Età;

        public Atleti() { }
        public Atleti(string n, string c, int e)
        {
            Nome = n;
            Cognome = c;
            Età = e;
        }

        public virtual void PrintInfo()
        {
            Console.Write($"Nome: {Nome}" + $"\nCognome: {Cognome}" + $"\nEtà: {Età}");
        }
    }
}
