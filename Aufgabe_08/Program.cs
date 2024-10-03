namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ganzzahlige Dezimalzahl (q to Quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int decimalNumber))
                {
                    string binary = Convert.ToString(decimalNumber, 2);
                    Console.WriteLine($"Binär: {binary}");
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige ganze Zahl ein oder 'q' zum Beenden.");
                }
            }
        }
    }
}
