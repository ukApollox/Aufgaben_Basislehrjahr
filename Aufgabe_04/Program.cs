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
            Console.Write("Zahl eingeben: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int monatZahl))
            {
                string monatName = "";

                switch (monatZahl)
                {
                    case 1:
                        monatName = "Januar";
                        break;
                    case 2:
                        monatName = "Februar";
                        break;
                    case 3:
                        monatName = "März";
                        break;
                    case 4:
                        monatName = "April";
                        break;
                    case 5:
                        monatName = "Mai";
                        break;
                    case 6:
                        monatName = "Juni";
                        break;
                    case 7:
                        monatName = "Juli";
                        break;
                    case 8:
                        monatName = "August";
                        break;
                    case 9:
                        monatName = "September";
                        break;
                    case 10:
                        monatName = "Oktober";
                        break;
                    case 11:
                        monatName = "November";
                        break;
                    case 12:
                        monatName = "Dezember";
                        break;
                    default:
                        Console.WriteLine("Ungültige Zahl. Bitte geben Sie eine Zahl zwischen 1 und 12 ein.");
                        return;
                }

                Console.WriteLine("Monat: " + monatName);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
