namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lange soll die Linie sein?");

            if (int.TryParse(Console.ReadLine(), out int length))
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Deine Zahl ist Ungültig!");
            }
        }
    }
}