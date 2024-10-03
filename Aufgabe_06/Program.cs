using System.Xml.Linq;

Console.WriteLine("-----------");
Console.WriteLine("Kleines 1x1");
Console.WriteLine("-----------");

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i * j}");

    }
    Console.WriteLine();
}
