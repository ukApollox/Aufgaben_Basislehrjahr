namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Random random = new Random();

            int returnValue = random.Next(1, 100);

            int vermutung = 0;

            Console.WriteLine("Errate die Zahl zwischen 1 und 100!");

            while (vermutung != returnValue)
            {
                vermutung = Convert.ToInt32(Console.ReadLine());

                if (vermutung < returnValue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Die Zahl ist grösser als " + vermutung);
                    Console.WriteLine("Versuche es nochmals!");
                }
                else if (vermutung > returnValue)
                {
                    Console.WriteLine();
                    Console.WriteLine("Die Zahl ist kleiner als " + vermutung);
                    Console.WriteLine("Versuche es nochmals!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Richtig " + vermutung + " ist die richtige Zahl!" );
            Console.ReadLine();

        }
    }
}
