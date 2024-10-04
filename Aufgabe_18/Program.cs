namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Dein Geburtsdatum (tt.mm.jjjj)");

                string input = Convert.ToString(Console.ReadLine());

                DateTime birthday; 
                DateTime today = DateTime.Today;

                if (DateTime.TryParse(input, out birthday))
                {

                    TimeSpan interval = today - birthday;


                    Console.WriteLine();
                    Console.WriteLine($"Du bist {(int)(interval.Days / 365.2422)} Jahre alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Du bist {(int)(interval.Days / 30.437)} Monate alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Du bist {interval.Days / 7} Wochen alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Du bist {interval.Days} Tage alt");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Bitte gebe eine gültiges Datum ein.");
                    Console.WriteLine();
                }
            }
        }
    }
}