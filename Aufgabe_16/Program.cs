namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vokale = "aeiouäöü";
            var vokalZähler = new Dictionary<char, int>();

            foreach (char vokal in vokale)
                vokalZähler[vokal] = 0;

            Console.WriteLine("Deine Eingabe: ");
            string input = Console.ReadLine()?.ToLower();

            int gesamtVokale = 0;

            foreach (char buchstabe in input ?? "")
            {
                if (vokalZähler.ContainsKey(buchstabe))
                {
                    vokalZähler[buchstabe]++;
                    gesamtVokale++;
                }
            }

            Console.WriteLine($"\nDein Text hat total {gesamtVokale} Vokale.");

            foreach (var vokal in vokalZähler)
                if (vokal.Value > 0)
                    Console.WriteLine($"Der Buchstabe '{vokal.Key}' kommt {vokal.Value} mal vor.");

            Console.ReadKey();
        }
    }
}
