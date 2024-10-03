namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int stammBreite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int stammHoehe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int kronenHoehe = Convert.ToInt32(Console.ReadLine());


            ZeichneBaum(stammBreite, stammHoehe, kronenHoehe);

            Console.ReadKey();
        }

        static void ZeichneBaum(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            ZeichneKrone(kronenHoehe);
            ZeichneStamm(stammBreite, stammHoehe, kronenHoehe);

        }

        static void ZeichneStamm(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            for (int i = 1; i <= stammHoehe; i++)
            {
                ZeichneZeile((kronenHoehe - 1) - (stammBreite / 2), stammBreite);
            }
        }

        static void ZeichneKrone(int kronenHoehe)
        {
            int sterne = 1;
            int leer = kronenHoehe - 1;

            for (int i = 1; i <= kronenHoehe; i++)
            {
                ZeichneZeile(leer, sterne);
                sterne += 2;
                leer -= 1;
            }
        }

        static void ZeichneZeile(int anzahlLeerzeichen, int anzahlSterne)
        {
            for (int i = 1; i <= anzahlLeerzeichen; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= anzahlSterne; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
