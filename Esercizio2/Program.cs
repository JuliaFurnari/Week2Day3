using System;
using System.Collections.Generic;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creare un programma che consente di gestire una squadra di calcio per una partita.
            //Gli atleti hanno nome, cognome, età;
            //I Calciatori hanno anche ruolo e numero maglia(ruoli = centrocampista, difensore, portiere e attaccante)
            //I Portieri sono calciatori e hanno numero maglia = 1(di default) e il numero di goal subiti.
            //Gli attaccanti sono calciatori hanno il numero goal fatti in una partita
            //Il centrocampista è un calciatore ha il numero di assist in una partita

            //Una squadra di calcio è formata da 11 calciatori di cui:
            // 1 portiere; 4 difensori; 3 centrocampisti; 3 attaccanti;

            //Per svolgere una partita serve anche un arbitro.
            //L'arbitro è un atleta, ma ha anche il numero di anni di carriera.
            //L'utente organizzatore deve poter creare due squadre e aggiungere un arbitro.
            //Quando crea il team, l'utente organizzatore sceglie tra una elenco (pre caricata)
            //di calciatori. Una calciatore non può essere inserito due volte.
            //Quando ha inserito tutti gli elementi della partita, stampare 'La partita può iniziare'.

            //Console.WriteLine("Stampa l'anagrafica del portiere.");
            //  Atleti p = new Portieri("Luca", "Rossi", 20, 0, 30);
            //  p.PrintInfo();
            Portieri p = new Portieri();
            List<Portieri> portieriItalia = new List<Portieri>();
            portieriItalia = p.ListaPortieriItalia();
            
            List<Calciatori> listaSquadraItalia = new List<Calciatori>();
            Console.WriteLine("Scegli i giocatori della squadra ITALIA!");
            Console.WriteLine("Scegli un portiere dalla seguente lista:");
            foreach (Portieri p1 in portieriItalia)
            {
                Console.WriteLine($"Digita {portieriItalia} per scegliere:");
                p1.PrintInfo();
                Console.WriteLine("\n***************");
            }
            int scelta = int.Parse(Console.ReadLine());

            portieriItalia[scelta].PrintInfo();







        }
    }
}
