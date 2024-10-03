using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Kilometer möchtest du rennen? ");
            int kilometer = Convert.ToInt32(Console.ReadLine());  // Verwende 'int' statt 'byte'

            if (kilometer >= 42)
            {
                Console.WriteLine("Du lügst, außer du bist David Goggins!");
                Console.ReadKey();
            }
            else
            {
                int n = kilometer * 1000 / 400;  // Anzahl der Runden basierend auf 400 m
                Console.WriteLine($"Du musst {n} Runden laufen. Bist du bereit? (Ja/Nein)");

                string antwort = Console.ReadLine();

                if (antwort == "Ja")
                {
                    Console.WriteLine("Viel Erfolg!");
                    int i = 1;  // Die Runden zählen ab 1

                    while (i <= n)
                    {
                        Console.WriteLine($"Du läufst Runde {i}");
                        i++;
                    }

                    Console.WriteLine("Du hast es geschafft!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Dann eben nicht.");
                    Console.ReadKey();
                }
            }
        }
    }
}
