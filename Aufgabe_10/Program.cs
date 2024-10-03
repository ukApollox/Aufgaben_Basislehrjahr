namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Zahl1: ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.Write("Zahl2: ");
            int zahl2 = int.Parse(Console.ReadLine());



            for (int i = zahl1; i <= zahl2; i++)
            {

                if (i % Quersumme(i) == 0)
                {
                    int g = i / Quersumme(i);
                    Console.WriteLine($"{i}, {Quersumme(i)}, {g}");
                }
            }
        }


        static int Quersumme(int zahl)
        {
            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            return sum;
        }
    }
}