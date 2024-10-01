using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 10)
            {
                Console.Write(i);
                i++;
            }

            Console.WriteLine("\nPress any key ...");
            Console.ReadKey();

        }
    }
}
