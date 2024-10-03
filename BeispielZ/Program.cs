namespace BeispielZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintGreeting("Jamie");
            string name = GetGreeting("Jamie");
            Console.WriteLine(GetGreeting("Jamie"));
            Console.WriteLine(name);
        }
        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Greeting: {name}");

        }
        static string GetGreeting(string name)
        {
            return $"Greetingagain: {name}";
        }
    }
}
