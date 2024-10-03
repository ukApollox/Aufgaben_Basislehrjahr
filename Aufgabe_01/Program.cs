using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl 1:");
            string Zahl1Input = Console.ReadLine();

            Console.WriteLine("Zahl 2:");
            string Zahl2Input = Console.ReadLine();

            float Zahl1 = Convert.ToSingle(Zahl1Input);
            float Zahl2 = Convert.ToSingle(Zahl2Input);

            float Summe = Zahl1 + Zahl2;

            Console.WriteLine("Summe: " + Summe);


            Console.WriteLine("\nPress any key ...");
            Console.ReadKey();
        }
    }
}
