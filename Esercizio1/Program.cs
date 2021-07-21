using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creare una classe Veicolo con le seguenti proprietà:
            //(brand, modello, codice); e poi le seguenti classi derivate:
            //Automobile (con proprietà targa e carburante) e bicicletta (con proprietà Elettrica/Non Elettrica).

            Console.WriteLine("\nLe proprietà dell'automobile sono:");
            Automobile auto = new Automobile("Fiat", "Panda", 500, "AJ567CT", "Diesel");
            auto.PrintInfo();
            Console.WriteLine("\nLe proprietà della bicicletta sono:");
            Bicicletta bici = new Bicicletta("Brand", "Modello", 123, true);
            bici.PrintInfo();

            //Si può inizializzare anche così

            Veicolo v = new Bicicletta("Brand1", "Modello1", 456, false);
            Console.WriteLine("\nLe proprietà della bicicletta sono:");
            v.PrintInfo();


        
        }
    }
}
