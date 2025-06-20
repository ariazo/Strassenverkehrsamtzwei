using System;
using System.Collections.Generic;

namespace Ueb11a_Strassenverkehrsamt
{
    /// <summary>
    /// Das Hauptprogramm ist das Strassenverkehrsamt.
    /// Es enthaelt eine Liste von Fahrzeugen (=Fahrzeugregister)
    /// </summary>
    internal class Program
    {
        private static List<Fahrzeug> fahrzeugRegister = new List<Fahrzeug>();

        private static void Main(string[] args)
        {
            bool bRun = true;
            while (bRun)
            {
                Console.WriteLine("Alle Fahrzeuge anzeigen:  a");
                Console.WriteLine("Fahrzeuge hinzufügen: h");
                Console.WriteLine("Programmende: e");
                var sWahl = Console.ReadLine();

                switch (sWahl.ToLower())
                {
                    case "a": ShowAllFahrzeuge(); break;
                    case "h":
                        bool bRunSubMenu = true;
                        while (bRunSubMenu)
                        {
                            Console.WriteLine("Beenden er Eingaben mit (j)");
                            var sEingabe = Console.ReadLine();
                            if (sEingabe.ToLower() == "j")
                            {
                                bRunSubMenu = false;
                                break;
                            }
                            else
                            {
                                // Eingabe des Halters des Fahrzeugs
                                Console.WriteLine("Halter: Vorname eingeben: ");
                                var sV = Console.ReadLine();
                                Console.WriteLine("Halter: Nachname eingeben: ");
                                var sN = Console.ReadLine();
                                Person halter = new Person();
                                halter.Vorname = sV;
                                halter.Nachname = sN;

                                var fzh = new Fahrzeug();
                                fzh.Halter = halter;

                                // Eingabe des Fahrzeugs
                                Console.Write("Kennzeichen eingeben: ");

                                var sKennzeichen = Console.ReadLine();
                                int nKennzeichen = 0;
                                int.TryParse(sKennzeichen, out nKennzeichen);
                                fzh.Kennzeichen = nKennzeichen;

                                Console.Write("Marke eingeben: ");
                                fzh.Marke = Console.ReadLine();

                                AddFahrzeug(fzh);
                            }
                        }
                        break;

                    case "e":
                        bRun = false;
                        Console.WriteLine("E N D E");
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Fügt jeweils 1 neues Fahrzeug zum Fahrzeugregister hinzu
        /// </summary>
        /// <param name="fhz"></param>
        private static void AddFahrzeug(Fahrzeug fhz)
        {
            fahrzeugRegister.Add(fhz);
        }

        /// <summary>
        /// Zeigt alle Fahrzeug und ihre Halter aus dem Fahrzeugregister an
        /// </summary>
        private static void ShowAllFahrzeuge()
        {
            foreach (var item in fahrzeugRegister)
            {
                Console.WriteLine(item.Kennzeichen + ", " + item.Marke + " " + item.Halter.Nachname);
            }
        }
    }
}