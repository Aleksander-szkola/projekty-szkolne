using System;
class Program
{
    static void Main()
    {
        Console.Title = "Sprawdzanie, czy tekst jest palindromem";

        Console.Write("Wpisz wyraz: ");
        string wyraz = Console.ReadLine();
        string zaryw = string.Empty;

        foreach (char c in wyraz)
        {
            zaryw = c + zaryw;
        }
        if (wyraz.ToLower() == zaryw.ToLower())
        {
            Console.WriteLine($"{wyraz} jest palindromem.");
        }
        else
        {
            Console.WriteLine($"{wyraz} nie jest palindromem.");
        }
    }
}