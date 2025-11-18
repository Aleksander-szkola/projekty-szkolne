using System;

class Program
{
    static void Main()
    {
        Console.Title = "Sprawdzanie parzystości liczby";
        Console.Write("Podaj liczbę: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine(n + " jest parzysta.");
        }
        else
        {
            Console.WriteLine(n + " jest nieparzysta.");
        }
    }
}
