using Newtonsoft.Json.Linq;
using System.Net;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Willst du noch einen Witz [j/n]:");
                Console.WriteLine();
                string userInput = Console.ReadLine();


                if (userInput.ToLower() == "j")
                {
                    string joke = GetJoke();
                    Console.WriteLine();
                    Console.WriteLine(joke);
                    Console.WriteLine();
                }
                else if (userInput.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Bitte gib 'j' oder 'n' ein.");
                    Console.WriteLine();
                }
            }
        }
        internal static string GetJoke()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                string jsonResponse = new StreamReader(responseStream).ReadToEnd();

                JArray array = JArray.Parse(jsonResponse);

                return array[0]["text"].ToString();
            }

            return string.Empty;
        }

    }
}
