namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Ihr Geburtsdatum (dd.mm.jjjj)");

                string input = Convert.ToString(Console.ReadLine());

                DateTime birthday;
                DateTime today = DateTime.Today;



                if (DateTime.TryParse(input, out birthday))
                {
                    TimeSpan interval = today - birthday;

                    Console.WriteLine();
                    Console.WriteLine($"Sie sind {(int)(interval.Days / 365.24)} Jahre alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Sie sind {(int)(interval.Days / 30.437)} Monate alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Sie sind {interval.Days / 7} Wochen alt");
                    Console.WriteLine("Oder: ");

                    Console.WriteLine($"Sie sind {interval.Days} Tage alt");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine gültiges Datum ein.");
                    Console.WriteLine();
                }

            }




        }
    }
}