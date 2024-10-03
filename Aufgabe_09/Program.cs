namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int zahl = int.Parse(Console.ReadLine());

            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            Console.WriteLine("Summe der Ziffern: " + sum);
        }
    }
}
