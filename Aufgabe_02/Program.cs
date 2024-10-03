using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            string MonatstageInput = Console.ReadLine();

            double Monatstage = Convert.ToDouble(MonatstageInput);

            if (Monatstage == 28 || Monatstage == 29 || Monatstage == 30 || Monatstage == 31)
            {
                double AnzahlSekunden = Monatstage * 24 * 60 * 60;
                Console.WriteLine("Anzahl Sekunden im Monat: " + AnzahlSekunden);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 28, 29, 30 oder 31 ein.");
            }

            Console.WriteLine("\nPress any key ...");
            Console.ReadKey();
        }
    }
}
