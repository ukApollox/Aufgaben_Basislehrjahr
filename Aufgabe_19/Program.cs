namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Make your calculation (or press Q to quit): ");
                string input = Console.ReadLine().Replace(" ", "");

                if (input.ToLower() == "q")
                {
                    break;
                }



                GetFirstZahl(input);
                GetOperator(input);
                GetSecondZahl(input);
                Console.WriteLine($"ihr reslutat ist: {Calculate(input)}");




            }
        }

        internal static int GetFirstZahl(string i)
        {
            string zahl1 = new string(i.TakeWhile(Char.IsDigit).ToArray());
            return Convert.ToInt32(zahl1);
        }

        internal static char GetOperator(string i)
        {

            char op = i.FirstOrDefault(c => !char.IsDigit(c));
            return (op);
        }

        internal static int GetSecondZahl(string i)
        {

            string zahl2 = i.Split(new char[] { '+', '-', '*', '/' })[1];
            return int.Parse(zahl2);

        }



        internal static int Calculate(string i)
        {

            if (GetOperator(i) == '+')
            {
                int result = GetFirstZahl(i) + GetSecondZahl(i);
                return result;
            }
            else if (GetOperator(i) == '-')
            {
                int result = GetFirstZahl(i) - GetSecondZahl(i);
                return result;
            }
            else if (GetOperator(i) == '*')
            {
                int result = GetFirstZahl(i) * GetSecondZahl(i);
                return result;
            }
            else if (GetOperator(i) == '/')
            {
                int result = GetFirstZahl(i) / GetSecondZahl(i);
                return result;
            }
            else if (GetOperator(i) == '%')
            {
                int result = GetFirstZahl(i) % GetSecondZahl(i);
                return result;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }


        }
    }
}